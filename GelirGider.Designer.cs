namespace PansiyonKayitUygulamasi
{
    partial class GelirGider
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblKasaToplam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPersonelMaas = new System.Windows.Forms.Label();
            this.LblAlinanUrun = new System.Windows.Forms.Label();
            this.LblFatura = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasadaki Toplam Tutar : ";
            // 
            // LblKasaToplam
            // 
            this.LblKasaToplam.AutoSize = true;
            this.LblKasaToplam.Location = new System.Drawing.Point(185, 21);
            this.LblKasaToplam.Name = "LblKasaToplam";
            this.LblKasaToplam.Size = new System.Drawing.Size(21, 16);
            this.LblKasaToplam.TabIndex = 1;
            this.LblKasaToplam.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Maaşları : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alınan Ürünlerin Toplamı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Faturalar : ";
            // 
            // LblPersonelMaas
            // 
            this.LblPersonelMaas.AutoSize = true;
            this.LblPersonelMaas.Location = new System.Drawing.Point(185, 53);
            this.LblPersonelMaas.Name = "LblPersonelMaas";
            this.LblPersonelMaas.Size = new System.Drawing.Size(21, 16);
            this.LblPersonelMaas.TabIndex = 5;
            this.LblPersonelMaas.Text = "00";
            // 
            // LblAlinanUrun
            // 
            this.LblAlinanUrun.AutoSize = true;
            this.LblAlinanUrun.Location = new System.Drawing.Point(185, 90);
            this.LblAlinanUrun.Name = "LblAlinanUrun";
            this.LblAlinanUrun.Size = new System.Drawing.Size(21, 16);
            this.LblAlinanUrun.TabIndex = 6;
            this.LblAlinanUrun.Text = "00";
            // 
            // LblFatura
            // 
            this.LblFatura.AutoSize = true;
            this.LblFatura.Location = new System.Drawing.Point(185, 127);
            this.LblFatura.Name = "LblFatura";
            this.LblFatura.Size = new System.Drawing.Size(21, 16);
            this.LblFatura.TabIndex = 7;
            this.LblFatura.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Personel Sayısı : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 22);
            this.textBox1.TabIndex = 9;
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(373, 113);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(359, 29);
            this.BtnHesapla.TabIndex = 10;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // GelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblFatura);
            this.Controls.Add(this.LblAlinanUrun);
            this.Controls.Add(this.LblPersonelMaas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblKasaToplam);
            this.Controls.Add(this.label1);
            this.Name = "GelirGider";
            this.Text = "GelirGider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblKasaToplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPersonelMaas;
        private System.Windows.Forms.Label LblAlinanUrun;
        private System.Windows.Forms.Label LblFatura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnHesapla;
    }
}