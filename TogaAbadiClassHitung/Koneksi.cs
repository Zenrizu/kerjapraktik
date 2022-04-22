﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TogaAbadiClassHitung
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region CONSTRUCTORS
        public Koneksi()
        {
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;
            this.Connect();
        }
        public Koneksi(string namaServer, string namaDatabase, string username, string password)
        {
            string connectionStr;
            if (password == "")
            {
                connectionStr = "Server=" + namaServer + ";Database=" + namaDatabase + ";Uid=" + username + ";";
            }
            else
            {
                connectionStr = "Server=" + namaServer + ";Database=" + namaDatabase + ";Uid=" + username + ";Pwd=" + password + ";";
            }

            this.KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = connectionStr;

            this.Connect();

            UpdateAppConfig(connectionStr);
        }
        #endregion

        #region PROPERTIES
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region METHODS
        public void Connect()
        {
            //Jika koneksi terbuka, tutup
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Clone();
            }
            KoneksiDB.Open();
        }
        public void UpdateAppConfig(string con)
        {
            //Membuka app config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //Set connection string di connection string
            config.ConnectionStrings.ConnectionStrings["namakoneksi"].ConnectionString = con;

            //Simpan app.config yang di update
            config.Save(ConfigurationSaveMode.Modified, true);

            //Reload app.config pake pengaturan baru
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public static void JalankanPerintahDML(string pSql)
        {
            //Buat koneksi yang udah ada di app config
            Koneksi k = new Koneksi();

            //Buat SQL Command
            MySqlCommand c = new MySqlCommand(pSql, k.KoneksiDB);

            //Menjalankan perintah INSERT/UPDATE/DELETE
            c.ExecuteNonQuery();
        }
        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }
        #endregion
    }
}
