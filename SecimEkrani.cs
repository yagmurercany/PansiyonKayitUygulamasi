using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonKayitUygulamasi
{
    public partial class SecimEkrani : Form
    {
        public SecimEkrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriIslemleri musteri = new MusteriIslemleri();
            musteri.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yine bekleriz!","Çıkış Yapıldı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdaIslemleri oda = new OdaIslemleri();
            oda.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriKontrol musteri = new MusteriKontrol();
            musteri.Show();
            this.Hide();
        }

        private void SecimEkrani_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPersonelMaas_Click(object sender, EventArgs e)
        {
            GelirGider gelirGider = new GelirGider();
            gelirGider.Show();
        }

        private void BtnMstok_Click(object sender, EventArgs e)
        {
            Stoklar stoklar = new Stoklar();   
            stoklar.Show();
            this.Hide();
        }

        private void BtnRadyo_Click(object sender, EventArgs e)
        {
            Radyo radyo = new Radyo();
            radyo.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Gazeteler gzt = new Gazeteler();
            gzt.Show();
        }
    }
}
