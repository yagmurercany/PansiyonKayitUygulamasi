namespace PansiyonKayitUygulamasi
{
    partial class MusteriKontrol
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
            this.components = new System.ComponentModel.Container();
            this.pansiyonKayitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pansiyonKayitDataSet = new PansiyonKayitUygulamasi.PansiyonKayitDataSet();
            this.BtnVerileriGoster = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Oda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ücret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GirişTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ÇıkışTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.CbCinsiyet = new System.Windows.Forms.ComboBox();
            this.MtbxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.BtnAnasayfa = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.TxtTc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pansiyonKayitDataSetBindingSource
            // 
            this.pansiyonKayitDataSetBindingSource.DataSource = this.pansiyonKayitDataSet;
            this.pansiyonKayitDataSetBindingSource.Position = 0;
            // 
            // pansiyonKayitDataSet
            // 
            this.pansiyonKayitDataSet.DataSetName = "PansiyonKayitDataSet";
            this.pansiyonKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnVerileriGoster
            // 
            this.BtnVerileriGoster.Location = new System.Drawing.Point(882, 12);
            this.BtnVerileriGoster.Name = "BtnVerileriGoster";
            this.BtnVerileriGoster.Size = new System.Drawing.Size(231, 39);
            this.BtnVerileriGoster.TabIndex = 1;
            this.BtnVerileriGoster.Text = "Verileri Göster";
            this.BtnVerileriGoster.UseVisualStyleBackColor = true;
            this.BtnVerileriGoster.Click += new System.EventHandler(this.BtnVerileriGoster_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Ad,
            this.Soyad,
            this.Cinsiyet,
            this.Telefon,
            this.Mail,
            this.Tc,
            this.Oda,
            this.Ücret,
            this.GirişTarihi,
            this.ÇıkışTarihi});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 282);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1101, 283);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 104;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 66;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            this.Soyad.Width = 77;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Text = "Cinsiyet";
            this.Cinsiyet.Width = 64;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 113;
            // 
            // Mail
            // 
            this.Mail.Text = "Mail";
            this.Mail.Width = 138;
            // 
            // Tc
            // 
            this.Tc.Text = "Tc";
            this.Tc.Width = 141;
            // 
            // Oda
            // 
            this.Oda.Text = "Oda";
            this.Oda.Width = 58;
            // 
            // Ücret
            // 
            this.Ücret.Text = "Ücret";
            this.Ücret.Width = 110;
            // 
            // GirişTarihi
            // 
            this.GirişTarihi.Text = "Giriş Tarihi";
            this.GirişTarihi.Width = 141;
            // 
            // ÇıkışTarihi
            // 
            this.ÇıkışTarihi.Text = "Çıkış Tarihi";
            this.ÇıkışTarihi.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(882, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(882, 102);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(231, 39);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(882, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(557, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "KAFAYI YEME NOKTASI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "ÜCRET";
            // 
            // TxtUcret
            // 
            this.TxtUcret.Location = new System.Drawing.Point(379, 39);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(156, 22);
            this.TxtUcret.TabIndex = 42;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(319, 102);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(86, 16);
            this.D.TabIndex = 41;
            this.D.Text = "ÇIKIŞ TARİHİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "GİRİŞ TARİHİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "ODA NUMARASI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "TC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "MAİL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "TELEFON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "CİNSİYET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "AD";
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Location = new System.Drawing.Point(414, 99);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(200, 22);
            this.DtpCikisTarihi.TabIndex = 32;
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Location = new System.Drawing.Point(414, 71);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(200, 22);
            this.DtpGirisTarihi.TabIndex = 31;
            // 
            // CbCinsiyet
            // 
            this.CbCinsiyet.FormattingEnabled = true;
            this.CbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.CbCinsiyet.Location = new System.Drawing.Point(98, 84);
            this.CbCinsiyet.Name = "CbCinsiyet";
            this.CbCinsiyet.Size = new System.Drawing.Size(142, 24);
            this.CbCinsiyet.TabIndex = 30;
            // 
            // MtbxTelefon
            // 
            this.MtbxTelefon.Location = new System.Drawing.Point(99, 119);
            this.MtbxTelefon.Mask = "(999) 000-0000";
            this.MtbxTelefon.Name = "MtbxTelefon";
            this.MtbxTelefon.Size = new System.Drawing.Size(141, 22);
            this.MtbxTelefon.TabIndex = 29;
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.Location = new System.Drawing.Point(435, 12);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(100, 22);
            this.TxtOdaNo.TabIndex = 28;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(67, 183);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(173, 22);
            this.TxtMail.TabIndex = 27;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.Location = new System.Drawing.Point(81, 50);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(159, 22);
            this.TxtSoyadi.TabIndex = 25;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(67, 20);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(173, 22);
            this.TxtAd.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "T.C. No:";
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(435, 147);
            this.TxtIsim.MaxLength = 11;
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(173, 22);
            this.TxtIsim.TabIndex = 46;
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.Location = new System.Drawing.Point(882, 237);
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            this.BtnAnasayfa.Size = new System.Drawing.Size(231, 39);
            this.BtnAnasayfa.TabIndex = 47;
            this.BtnAnasayfa.Text = "AnaSayfaya Geri Dön";
            this.BtnAnasayfa.UseVisualStyleBackColor = true;
            this.BtnAnasayfa.Click += new System.EventHandler(this.BtnAnasayfa_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(882, 192);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(231, 39);
            this.BtnTemizle.TabIndex = 48;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(67, 155);
            this.TxtTc.MaxLength = 11;
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(173, 22);
            this.TxtTc.TabIndex = 49;
            // 
            // MusteriKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 577);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnAnasayfa);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtUcret);
            this.Controls.Add(this.D);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpCikisTarihi);
            this.Controls.Add(this.DtpGirisTarihi);
            this.Controls.Add(this.CbCinsiyet);
            this.Controls.Add(this.MtbxTelefon);
            this.Controls.Add(this.TxtOdaNo);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtSoyadi);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnVerileriGoster);
            this.Name = "MusteriKontrol";
            this.Text = "MusteriKontrol";
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonKayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pansiyonKayitDataSetBindingSource;
        private PansiyonKayitDataSet pansiyonKayitDataSet;
        private System.Windows.Forms.Button BtnVerileriGoster;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader Cinsiyet;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Tc;
        private System.Windows.Forms.ColumnHeader Oda;
        private System.Windows.Forms.ColumnHeader Ücret;
        private System.Windows.Forms.ColumnHeader GirişTarihi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.ComboBox CbCinsiyet;
        private System.Windows.Forms.MaskedTextBox MtbxTelefon;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Button BtnAnasayfa;
        private System.Windows.Forms.ColumnHeader ÇıkışTarihi;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.TextBox TxtTc;
    }
}