using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogaAbadiClassHitung;

namespace kerjapraktik
{
    public partial class FormInputGaji : Form
    {
        public FormInputGaji()
        {
            InitializeComponent();
        }
        List<Terambils> listT = new List<Terambils>();
        List<Pekerjas> listP = new List<Pekerjas>();
        List<Bagians> listBagian = new List<Bagians>();
        List<ArtikelPotongs> listAp = new List<ArtikelPotongs>();
        List<Gajis> listGaji = new List<Gajis>();
        int subtotal = 0;
        string id = "";
        bool baru = true;
        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonKunciGaji_Click(object sender, EventArgs e)
        {
            if (comboBoxNama.Enabled == true)
            {
                comboBoxNama.Enabled = false;
                textBoxTempat.Enabled = false;
                dateTimePickerTanggalGajian.Enabled = false;
                buttonKunciGaji.Text = "Lepas Kunci";
            }
            else
            {
                comboBoxNama.Enabled = true;
                textBoxTempat.Enabled = true;
                dateTimePickerTanggalGajian.Enabled = true;
                buttonKunciGaji.Text = "Kunci Gaji";
            }
        }

        private void FormInputGaji_Load(object sender, EventArgs e)
        {
            baru = true;
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            listBagian = Bagians.BacaData("id_artikel", textBoxArt.Text);
            comboBoxBagian.DataSource = listBagian;
            comboBoxBagian.DisplayMember = "bagian";
            FormatDataGridBagian();
            TampilDataGridBagian();
        }

        private void FormatDataGridBagian()
        {
            dataGridViewDataBagian.Columns.Clear();

            dataGridViewDataBagian.Columns.Add("bagian", "Bagian");
            dataGridViewDataBagian.Columns.Add("tersedia", "Tersedia"); //diambil
            dataGridViewDataBagian.Columns.Add("harga", "Harga");

            dataGridViewDataBagian.Columns["bagian"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDataBagian.Columns["tersedia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDataBagian.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewData.AllowUserToAddRows = true;
            dataGridViewData.ReadOnly = false;
        }
        private void TampilDataGridBagian()
        {
            if (listBagian.Count > 0)
            {
                dataGridViewDataBagian.Rows.Clear();
                foreach (Bagians b in listBagian)
                {
                    dataGridViewDataBagian.Rows.Add(b.Bagian,b.Tersedia, b.Biaya_Satuan);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }

        private void FormatDataGridGaji()
        {//sisi kanan
            dataGridViewData.Columns.Clear();
            dataGridViewData.Columns.Add("no", "No");
            dataGridViewData.Columns.Add("kodeArtikel", "Kode Artikel"); 
            dataGridViewData.Columns.Add("seri", "Seri");
            dataGridViewData.Columns.Add("bagian", "Bagian");
            dataGridViewData.Columns.Add("jumlah", "Jumlah");
            dataGridViewData.Columns.Add("biaya", "Biaya");
            dataGridViewData.Columns.Add("total", "Total");

            dataGridViewData.Columns["no"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["kodeArtikel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["seri"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;  
            dataGridViewData.Columns["bagian"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["biaya"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.ReadOnly = true;
        }
        private void TampilDataGridGaji()
        {//sisi kanan
            //iki sisan
            if (listT.Count > 0)
            {
                int count = 1;
                subtotal = 0;
                foreach (Terambils t in listT)
                {
                    int totalan =  t.Diambil * t.Satuan;
                    dataGridViewData.Rows.Add(count, t.KodeAp, t.Seri, t.Bagian, t.Diambil, t.Satuan,totalan);
                    count++;
                    subtotal += totalan;
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }

        private void buttonTambahBagian_Click(object sender, EventArgs e)
        {
            List<Pekerjas> listP = Pekerjas.BacaData("nama", textBoxNama.Text);
            Pekerjas p = new Pekerjas(listP[0].IdPekerjas, listP[0].Nama);
            DateTime tanggal = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            Gajis g = new Gajis(textBoxTempat.Text, tanggal, 0, 0, 0, p);
            if (baru ==true)
            {
                
                //int idG = Gajis.TambahData(g,p, DateTime.Parse(dateTimePickerTanggalGajian.Text));
                //biar ga buat baru terus2an
                Gajis.TambahData(g, p, tanggal);
                baru = false;
                MessageBox.Show("Tambah bagian pada gaji berhasil");
            }
            else
            {
                MessageBox.Show("Jumlah ambil melebihi ketersediaan");
            }
            //tambah gaji
            

            listBagian = Bagians.BacaData("bagian", comboBoxBagian.Text);
            Bagians b = new Bagians(listBagian[0].IdBagians, listBagian[0].Bagian, listBagian[0].Tersedia, listBagian[0].Biaya_Satuan);

            if (b.Tersedia >= int.Parse(textBoxJumlah.Text))//bila tersedia<ambil
            {
                //kurangi tersedia dari db
                int tersedia = b.Tersedia - int.Parse(textBoxJumlah.Text);
                Bagians b2 = new Bagians(listBagian[0].IdBagians, listBagian[0].Bagian, tersedia, listBagian[0].Biaya_Satuan);
                Bagians.UbahDataId(b2);

                //tambah terambils
                Terambils t = new Terambils(g, b, int.Parse(textBoxJumlah.Text));
                Terambils.TambahData(t, g, b);
                listT = Terambils.BacaData("gajis_id", "", textBoxArt.Text);
            }

            FormatDataGridGaji();
            TampilDataGridGaji();

            //tampilakn subtotal

            textBoxSubtotal.Text = subtotal.ToString();


            //kasbon 
            listGaji = Gajis.BacaData("id", id);
            int kasbon = listGaji[0].Kasbon;
            textBoxSisa.Text = kasbon.ToString();

            //Bagians b = new Bagians();
            

            //tampilkan data di datagridview
            listBagian = Bagians.BacaData("id_artikel", textBoxArt.Text);
            TampilDataGridBagian();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

            try
            {
                int kasbon = int.Parse(textBoxKasbon.Text);
                int kasInp = int.Parse(textBoxSisa.Text) + kasbon;
                int potong = int.Parse(textBoxPotong.Text);
                int total = subtotal - potong + kasbon;
                listP = Pekerjas.BacaData("nama", textBoxNama.Text);
                listGaji = Gajis.BacaData("id", id);
                Pekerjas p = new Pekerjas(listP[0].IdPekerjas, listP[0].Nama);
                Gajis g2 = new Gajis(id, listGaji[0].Tanggal, subtotal, kasInp, total, p);

                Gajis.UbahData(g2);

                MessageBox.Show("Tambah gaji berhasil");
            }
            catch (Exception ex)
            {

                MessageBox.Show("message : "+ex);
            }

            


        }

        private void textBoxSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int kasbon = int.Parse(textBoxKasbon.Text);
            int potong = int.Parse(textBoxPotong.Text);
            int total = subtotal - potong + kasbon;
            textBoxTotal.Text = total.ToString();
        }
    }
}
