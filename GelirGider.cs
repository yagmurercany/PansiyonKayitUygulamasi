using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.CodeDom.Compiler;

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
            
        }
        private void veriler2()
        {
                       ListView2.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  AlinanUrunler", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                {
                    ekle.Text = dr["Gıda"].ToString();
                    ekle.SubItems.Add(dr["İçecek"].ToString());
                    ekle.SubItems.Add(dr["Çerezler"].ToString());
                    listView1.Items.Add(ekle);
                }
            }
            con.Close();
        }
    }
}
