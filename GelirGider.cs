using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PansiyonKayitUygulamasi
{
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC0R723;Initial Catalog=PansiyonKayit;Integrated Security=True;Encrypt=False");

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            LblPersonelMaas.Text = (personel * 1500).ToString();

            int sonuc, kasa, gider;

            kasa = Convert.ToInt32(LblKasaToplam.Text);
            gider = Convert.ToInt16(LblPersonelMaas.Text) + Convert.ToInt16(LblAlinanUrun.Text) + Convert.ToInt16(LblAlinanUrunler1.Text) + Convert.ToInt16(LblAlinanUrunler2.Text) + Convert.ToInt16(LblFatura.Text) + Convert.ToInt16(lblFatura1.Text) + Convert.ToInt16(lblFatura2.Text);
            sonuc = kasa - gider;

            label2.Text = sonuc.ToString();
        }

        private void GelirGider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar 
            con.Open();
            SqlCommand cmd = new SqlCommand("select sum(ücret) as toplam from musterikayit", con);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            con.Close();

            //gıda stokların giderleri
            con.Open();

            SqlCommand cmd2 = new SqlCommand("select sum(Gıda) as toplam1 from AlinanUrunler", con);
            SqlDataReader oku2 = cmd2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanUrun.Text = oku2["toplam1"].ToString();
            }
            con.Close();

            //içecek stokların giderleri
            con.Open();

            SqlCommand cmd3 = new SqlCommand("select sum(İçecek) as toplam2 from AlinanUrunler", con);
            SqlDataReader oku3 = cmd3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlinanUrunler1.Text = oku3["toplam2"].ToString();
            }
            con.Close();

            // atıştırmalık stokların giderleri
            con.Open();

            SqlCommand cmd4 = new SqlCommand("select sum(Çerezler) as toplam3 from AlinanUrunler", con);
            SqlDataReader oku4 = cmd4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlinanUrunler2.Text = oku4["toplam3"].ToString();
            }
            con.Close();

            //elektrik giderleri

            con.Open();

            SqlCommand cmd5 = new SqlCommand("select sum(Elektrik) as toplam4 from Faturalar", con);
            SqlDataReader oku5 = cmd5.ExecuteReader();
            while (oku5.Read())
            {
                LblFatura.Text = oku5["toplam4"].ToString();
            }
            con.Close();

            //su giderleri

            con.Open();

            SqlCommand cmd6 = new SqlCommand("select sum(Su) as toplam5 from Faturalar", con);
            SqlDataReader oku6 = cmd6.ExecuteReader();
            while (oku6.Read())
            {
                lblFatura1.Text = oku6["toplam5"].ToString();
            }
            con.Close();

            //internet giderleri

            con.Open();

            SqlCommand cmd7 = new SqlCommand("select sum(İnternet) as toplam6 from Faturalar", con);
            SqlDataReader oku7 = cmd7.ExecuteReader();
            while (oku7.Read())
            {
                lblFatura2.Text = oku7["toplam6"].ToString();
            }
            con.Close();

        }

    }
}
