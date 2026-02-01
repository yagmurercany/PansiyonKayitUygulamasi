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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PansiyonKayitUygulamasi
{
    public partial class MusteriKontrol : Form
    {

        public MusteriKontrol()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC0R723;Initial Catalog=PansiyonKayit;Integrated Security=True;Encrypt=False");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from musterikayit",con);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musteriID"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["ücret"].ToString());
                ekle.SubItems.Add(oku["giristarihi"].ToString());
                ekle.SubItems.Add(oku["cikistarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            con.Close();
        }


        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text); //id kök değerdir.
            TxtAd.Text = listView1.SelectedItems[0].SubItems[1].Text; //subitems alt alan adı oluyor . öğe olarak düşünülebilir.
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            
            MtbxTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
           
            if (TxtOdaNo.Text == "101")
            {
                SqlCommand cmd = new SqlCommand("delete from Oda101 where Adi='" + TxtAd.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "102")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda102 where Adi='" + TxtAd.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "103")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda103 where Adi='" + TxtAd.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "104")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda104 where Adi='" + TxtAd.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "105")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda105 where Adi='" + TxtAd.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "106")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda106 where Adi='" + TxtAd.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "107")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda107 where Adi='" + TxtAd.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "108")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda108 where Adi='" + TxtAd.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "109")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda109 where Adi='" + TxtAd.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                verilerigoster();
            }
        }

        private void BtnAnasayfa_Click(object sender, EventArgs e)
        {
            SecimEkrani kontrol = new SecimEkrani();
            kontrol.Show();
            
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtSoyadi.Clear();  
            CbCinsiyet.Text = "";   
            MtbxTelefon.Clear();
            TxtMail.Clear();
            TxtTc.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update musterikayit set ad='" + TxtAd.Text + "', soyad='" + TxtSoyadi.Text + "', cinsiyet='" + CbCinsiyet.Text + "', telefon='" + MtbxTelefon.Text + "', mail='" + TxtMail.Text + "', tc='" + TxtTc.Text + "', oda='" + TxtOdaNo.Text + "', ücret='" + TxtUcret.Text + "', giristarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "', cikistarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where musteriID=" + id + "", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            con.Close();
            verilerigoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from musterikayit where Tc like '%"+TxtTc.Text+"%'", con);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musteriID"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["ücret"].ToString());
                ekle.SubItems.Add(oku["giristarihi"].ToString());
                ekle.SubItems.Add(oku["cikistarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            con.Close();
        }
    }
}
