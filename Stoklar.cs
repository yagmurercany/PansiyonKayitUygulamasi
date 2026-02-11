using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonKayitUygulamasi
{
    public partial class Stoklar : Form
    {
        public Stoklar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC0R723;Initial Catalog=PansiyonKayit;Integrated Security=True;Encrypt=False");

        private void veriler()
        {
            listView1.Items.Clear();
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
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into AlinanUrunler (Gıda,İçecek,Çerezler) values ( '" + TxtGida.Text + "' ,'" + Txtİcecek.Text + "','" + TxtAtistirmalik.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            veriler();

        }

        private void Stoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();

        }
        private void veriler2()
        {
            listView2.Items.Clear();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from  Faturalar", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                ListViewItem ekle = new ListViewItem();
                {
                    ekle.Text = dr1["Elektrik"].ToString();
                    ekle.SubItems.Add(dr1["Su"].ToString());
                    ekle.SubItems.Add(dr1["İnternet"].ToString());
                    listView2.Items.Add(ekle);
                }
            }
            con.Close();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("insert into Faturalar (Elektrik,Su,İnternet) values ( '" + TxtElektrik.Text + "' ,'" + TxtSu.Text + "','" + Txtİnternet.Text + "')", con);
            cmd1.ExecuteNonQuery();
            con.Close();
            veriler2();
        }
    }
}
