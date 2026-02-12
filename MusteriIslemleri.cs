using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PansiyonKayitUygulamasi
{
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC0R723;Initial Catalog=PansiyonKayit;Integrated Security=True;Encrypt=False");
        private void Btn101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Btn102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Btn103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda103 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Btn104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda104 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Btn105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda105 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Btn106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda106 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Btn107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda107 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Btn108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda108 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Btn109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda109 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dolu Odayı Gösterir. (KIRMIZI)");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boş Odayı Gösterir.(YEŞİL)");
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into musterikayit (ad,soyad,cinsiyet,telefon,mail,tc,oda,ücret,giristarihi,cikistarihi) values ('" + TxtAd.Text + "','" + TxtSoyadi.Text + "','" + CbCinsiyet.Text + "','" + MtbxTelefon.Text + "','" + TxtMail.Text + "','" + TxtTc.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı.");

        }
        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);
            TimeSpan sonuc = BuyukTarih - KucukTarih;
            ucret = Convert.ToInt32(sonuc.TotalDays) * 200;
            TxtUcret.Text = ucret.ToString();
            label11.Text = sonuc.TotalDays.ToString();
        }

        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);
            TimeSpan sonuc = BuyukTarih - KucukTarih;
            ucret = Convert.ToInt32(sonuc.TotalDays) * 200;
            TxtUcret.Text = ucret.ToString();
            label11.Text = sonuc.TotalDays.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SecimEkrani kontrol = new SecimEkrani();
            kontrol.Show();
            this.Hide();
        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            //ODA 101
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Oda101", con);
            SqlDataReader oku1 = cmd1.ExecuteReader();
            while (oku1.Read())
            {
                Btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            con.Close();
            if (Btn101.Text != "101")
            {
                Btn101.BackColor = Color.Red;
                Btn101.Enabled = false;
            }
            else if (Btn102.Text == "101")
            {
                Btn102.BackColor = Color.Green;
            }
            //ODA 102
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Oda102", con);
            SqlDataReader oku2 = cmd2.ExecuteReader();
            while (oku2.Read())
            {
                Btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            con.Close();
            if (Btn102.Text != "102")
            {
                Btn102.BackColor = Color.Red;
                Btn102.Enabled = false;
            }
            else if (Btn102.Text == "102")
            {
                Btn102.BackColor = Color.Green;
            }
            //ODA 103
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select * from Oda103", con);
            SqlDataReader oku3 = cmd3.ExecuteReader();
            while (oku3.Read())
            {
                Btn102.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            con.Close();
            if (Btn103.Text != "103")
            {
                Btn103.BackColor = Color.Red;
                Btn103.Enabled = false;
            }
            else if (Btn103.Text == "103")
            {
                Btn103.BackColor = Color.Green;
            }
            //ODA 104
            con.Open();
            SqlCommand cmd4 = new SqlCommand("select * from Oda104", con);
            SqlDataReader oku4 = cmd3.ExecuteReader();
            while (oku4.Read())
            {
                Btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            con.Close();
            if (Btn104.Text != "104")
            {
                Btn104.BackColor = Color.Red;
                Btn104.Enabled = false;
            }
            else if (Btn104.Text == "104")
            {
                Btn104.BackColor = Color.Green;
            }
            //ODA 105
            con.Open();
            SqlCommand cmd5 = new SqlCommand("select * from Oda105", con);
            SqlDataReader oku5 = cmd5.ExecuteReader();
            while (oku5.Read())
            {
                Btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            con.Close();
            if (Btn105.Text != "105")
            {
                Btn105.BackColor = Color.Red;
                Btn105.Enabled = false;
            }
            else if (Btn105.Text == "105")
            {
                Btn105.BackColor = Color.Green;
            }
            //ODA 106
            con.Open();
            SqlCommand cmd6 = new SqlCommand("select * from Oda106", con);
            SqlDataReader oku6 = cmd6.ExecuteReader();
            while (oku6.Read())
            {
                Btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            con.Close();
            if (Btn106.Text != "106")
            {
                Btn106.BackColor = Color.Red;
                Btn106.Enabled = false;
            }
            else if (Btn106.Text == "106")
            {
                Btn106.BackColor = Color.Green;
            }
            //ODA 107
            con.Open();
            SqlCommand cmd7 = new SqlCommand("select * from Oda107", con);
            SqlDataReader oku7 = cmd7.ExecuteReader();
            while (oku7.Read())
            {
                Btn102.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            con.Close();
            if (Btn107.Text != "107")
            {
                Btn107.BackColor = Color.Red;
                Btn107.Enabled = false;
            }
            else if (Btn107.Text == "107")
            {
                Btn107.BackColor = Color.Green;
            }
            //ODA 108
            con.Open();
            SqlCommand cmd8 = new SqlCommand("select * from Oda108", con);
            SqlDataReader oku8 = cmd8.ExecuteReader();
            while (oku8.Read())
            {
                Btn102.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            con.Close();
            if (Btn108.Text != "108")
            {
                Btn108.BackColor = Color.Red;
                Btn108.Enabled = false;
            }
            else if (Btn108.Text == "108")
            {
                Btn108.BackColor = Color.Green;
            }
            //ODA 109
            con.Open();
            SqlCommand cmd9 = new SqlCommand("select * from Oda109", con);
            SqlDataReader oku9 = cmd9.ExecuteReader();
            while (oku9.Read())
            {
                Btn102.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            con.Close();
            if (Btn109.Text != "109")
            {
                Btn109.BackColor = Color.Red;
                Btn109.Enabled = false;
            }
            else if (Btn109.Text == "109")
            {
                Btn109.BackColor = Color.Green;
            }
        }
    }
}
