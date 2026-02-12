using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PansiyonKayitUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC0R723;Initial Catalog=PansiyonKayit;Integrated Security=True;Encrypt=False");

        private void BtnGiris_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "Select * From AdminGiris where KullaniciAdi=@kadi and Sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("kadi", TxtKadi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", TxtSifre.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    SecimEkrani se = new SecimEkrani();
                    se.Show();
                    this.Hide();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
