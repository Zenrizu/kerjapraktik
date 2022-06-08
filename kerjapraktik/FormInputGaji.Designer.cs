
namespace kerjapraktik
{
    partial class FormInputGaji
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCari = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.buttonTambahBagian = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxBagian = new System.Windows.Forms.ComboBox();
            this.Biaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewDataBagian = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxArt = new System.Windows.Forms.TextBox();
            this.buttonKunciGaji = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.totalan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxPotong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSisa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.art = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bagian = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateTimePickerTanggalGajian = new System.Windows.Forms.DateTimePicker();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTempat = new System.Windows.Forms.TextBox();
            this.textBoxKasbon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBagian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.Linen;
            this.buttonCari.Location = new System.Drawing.Point(388, 205);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(99, 29);
            this.buttonCari.TabIndex = 133;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 131;
            this.label12.Text = "JUMLAH :";
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(95, 267);
            this.textBoxJumlah.Multiline = true;
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(143, 28);
            this.textBoxJumlah.TabIndex = 130;
            // 
            // buttonTambahBagian
            // 
            this.buttonTambahBagian.Location = new System.Drawing.Point(388, 266);
            this.buttonTambahBagian.Name = "buttonTambahBagian";
            this.buttonTambahBagian.Size = new System.Drawing.Size(99, 32);
            this.buttonTambahBagian.TabIndex = 128;
            this.buttonTambahBagian.Text = "Tambah Bagian";
            this.buttonTambahBagian.UseVisualStyleBackColor = true;
            this.buttonTambahBagian.Click += new System.EventHandler(this.buttonTambahBagian_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 127;
            this.label13.Text = "BAGIAN :";
            // 
            // comboBoxBagian
            // 
            this.comboBoxBagian.FormattingEnabled = true;
            this.comboBoxBagian.Items.AddRange(new object[] {
            "Gosok krah",
            "",
            "Krah ",
            "",
            "Badan (include badan depan, belakang, skaur, jahit tangan) ",
            "",
            "Roges",
            "",
            "Obras tangan",
            "",
            "Tindes tangan",
            "",
            "Make up",
            "",
            "Lipat bawah",
            "",
            "Naskat",
            "",
            "Kancing",
            "",
            "Bersih benang",
            "",
            "Gosok"});
            this.comboBoxBagian.Location = new System.Drawing.Point(96, 240);
            this.comboBoxBagian.Name = "comboBoxBagian";
            this.comboBoxBagian.Size = new System.Drawing.Size(276, 21);
            this.comboBoxBagian.TabIndex = 126;
            // 
            // Biaya
            // 
            this.Biaya.HeaderText = "ColumnBiaya";
            this.Biaya.Name = "Biaya";
            // 
            // ColumnJumlah
            // 
            this.ColumnJumlah.HeaderText = "ColumnJumlah";
            this.ColumnJumlah.Name = "ColumnJumlah";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ColumnBagian";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(198, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 132;
            this.label14.Text = "DATA BAGIAN";
            // 
            // dataGridViewDataBagian
            // 
            this.dataGridViewDataBagian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBagian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ColumnJumlah,
            this.Biaya});
            this.dataGridViewDataBagian.Location = new System.Drawing.Point(15, 340);
            this.dataGridViewDataBagian.Name = "dataGridViewDataBagian";
            this.dataGridViewDataBagian.Size = new System.Drawing.Size(357, 239);
            this.dataGridViewDataBagian.TabIndex = 129;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 125;
            this.label11.Text = "NO ARTIKEL :";
            // 
            // textBoxArt
            // 
            this.textBoxArt.Location = new System.Drawing.Point(95, 206);
            this.textBoxArt.Multiline = true;
            this.textBoxArt.Name = "textBoxArt";
            this.textBoxArt.Size = new System.Drawing.Size(277, 28);
            this.textBoxArt.TabIndex = 124;
            // 
            // buttonKunciGaji
            // 
            this.buttonKunciGaji.Location = new System.Drawing.Point(386, 137);
            this.buttonKunciGaji.Name = "buttonKunciGaji";
            this.buttonKunciGaji.Size = new System.Drawing.Size(101, 37);
            this.buttonKunciGaji.TabIndex = 123;
            this.buttonKunciGaji.Text = "Kunci Gaji";
            this.buttonKunciGaji.UseVisualStyleBackColor = true;
            this.buttonKunciGaji.Click += new System.EventHandler(this.buttonKunciGaji_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(331, 13);
            this.label10.TabIndex = 122;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "---------------------------";
            // 
            // totalan
            // 
            this.totalan.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.totalan.HeaderText = "TOTALAN";
            this.totalan.Name = "totalan";
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(1027, 500);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(131, 31);
            this.buttonTambah.TabIndex = 121;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxTotal.Location = new System.Drawing.Point(623, 537);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(177, 28);
            this.textBoxTotal.TabIndex = 120;
            this.textBoxTotal.Text = "0";
            // 
            // textBoxPotong
            // 
            this.textBoxPotong.Location = new System.Drawing.Point(623, 503);
            this.textBoxPotong.Multiline = true;
            this.textBoxPotong.Name = "textBoxPotong";
            this.textBoxPotong.Size = new System.Drawing.Size(177, 28);
            this.textBoxPotong.TabIndex = 118;
            this.textBoxPotong.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 117;
            this.label8.Text = "POTONG BON : ";
            // 
            // textBoxSisa
            // 
            this.textBoxSisa.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxSisa.Enabled = false;
            this.textBoxSisa.Location = new System.Drawing.Point(623, 434);
            this.textBoxSisa.Multiline = true;
            this.textBoxSisa.Name = "textBoxSisa";
            this.textBoxSisa.Size = new System.Drawing.Size(177, 28);
            this.textBoxSisa.TabIndex = 116;
            this.textBoxSisa.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "SISA BON : ";
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxSubtotal.Enabled = false;
            this.textBoxSubtotal.Location = new System.Drawing.Point(623, 400);
            this.textBoxSubtotal.Multiline = true;
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.Size = new System.Drawing.Size(177, 28);
            this.textBoxSubtotal.TabIndex = 114;
            this.textBoxSubtotal.Text = "0";
            this.textBoxSubtotal.TextChanged += new System.EventHandler(this.textBoxSubtotal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "SUBTOTAL : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(831, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "---------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(561, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 119;
            this.label9.Text = "TOTAL : ";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.art,
            this.jumlah,
            this.bagian,
            this.harga,
            this.totalan});
            this.dataGridViewData.Location = new System.Drawing.Point(515, 64);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(643, 317);
            this.dataGridViewData.TabIndex = 111;
            // 
            // no
            // 
            this.no.HeaderText = "NO";
            this.no.Name = "no";
            // 
            // art
            // 
            this.art.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.art.HeaderText = "ARTIKEL-SERI-SIZE";
            this.art.Name = "art";
            // 
            // jumlah
            // 
            this.jumlah.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.jumlah.HeaderText = "JUMLAH";
            this.jumlah.Name = "jumlah";
            // 
            // bagian
            // 
            this.bagian.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.bagian.HeaderText = "BAGIAN";
            this.bagian.Name = "bagian";
            // 
            // harga
            // 
            this.harga.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.harga.HeaderText = "HARGA";
            this.harga.Name = "harga";
            // 
            // dateTimePickerTanggalGajian
            // 
            this.dateTimePickerTanggalGajian.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerTanggalGajian.Location = new System.Drawing.Point(126, 143);
            this.dateTimePickerTanggalGajian.Name = "dateTimePickerTanggalGajian";
            this.dateTimePickerTanggalGajian.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerTanggalGajian.TabIndex = 110;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(84, 64);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(277, 28);
            this.textBoxNama.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "TEMPAT   : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "NAMA : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 104;
            this.label1.Text = "FORM INPUT GAJI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "TANGGAL GAJIAN : ";
            // 
            // textBoxTempat
            // 
            this.textBoxTempat.Location = new System.Drawing.Point(84, 106);
            this.textBoxTempat.Multiline = true;
            this.textBoxTempat.Name = "textBoxTempat";
            this.textBoxTempat.Size = new System.Drawing.Size(277, 28);
            this.textBoxTempat.TabIndex = 108;
            // 
            // textBoxKasbon
            // 
            this.textBoxKasbon.Location = new System.Drawing.Point(623, 469);
            this.textBoxKasbon.Multiline = true;
            this.textBoxKasbon.Name = "textBoxKasbon";
            this.textBoxKasbon.Size = new System.Drawing.Size(177, 28);
            this.textBoxKasbon.TabIndex = 135;
            this.textBoxKasbon.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(552, 472);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 134;
            this.label15.Text = "KASBON : ";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(817, 531);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(131, 31);
            this.buttonCheck.TabIndex = 136;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // FormInputGaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 591);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxKasbon);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.buttonTambahBagian);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxBagian);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridViewDataBagian);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxArt);
            this.Controls.Add(this.buttonKunciGaji);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxPotong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSisa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.dateTimePickerTanggalGajian);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTempat);
            this.Name = "FormInputGaji";
            this.Text = "Form Input Gaji";
            this.Load += new System.EventHandler(this.FormInputGaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBagian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.Button buttonTambahBagian;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxBagian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridViewDataBagian;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxArt;
        private System.Windows.Forms.Button buttonKunciGaji;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewComboBoxColumn totalan;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxPotong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewComboBoxColumn art;
        private System.Windows.Forms.DataGridViewComboBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewComboBoxColumn bagian;
        private System.Windows.Forms.DataGridViewComboBoxColumn harga;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalGajian;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTempat;
        private System.Windows.Forms.TextBox textBoxKasbon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonCheck;
    }
}