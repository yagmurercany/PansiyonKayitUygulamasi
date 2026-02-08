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
                    
            }

        private void Stoklar_Load(object sender, EventArgs e)
        {
            veriler();

        }
    }
    }
