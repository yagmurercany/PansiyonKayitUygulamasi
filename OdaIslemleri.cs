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
    public partial class OdaIslemleri : Form
    {
        public OdaIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CC0R723;Initial Catalog=PansiyonKayit;Integrated Security=True;Encrypt=False");

        private void OdaIslemleri_Load(object sender, EventArgs e)
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
            }
            else if (Btn102.Text == "101")
            {
                Btn101.BackColor = Color.Green;
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
            }
            else if (Btn103.Text == "103")
            {
                Btn103.BackColor = Color.Green;
            }
            //ODA 104
            con.Open();
            SqlCommand cmd4 = new SqlCommand("select * from Oda104", con);
            SqlDataReader oku4 = cmd4.ExecuteReader();
            while (oku4.Read())
            {
                Btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            con.Close();
            if (Btn104.Text != "104")
            {
                Btn104.BackColor = Color.Red;
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
                Btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            con.Close();
            if (Btn108.Text != "108")
            {
                Btn108.BackColor = Color.Red;
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
                Btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            con.Close();
            if (Btn109.Text != "109")
            {
                Btn109.BackColor = Color.Red;
            }
            else if (Btn109.Text == "109")
            {
                Btn109.BackColor = Color.Green;
            }
        }
    }
}
        
            
            