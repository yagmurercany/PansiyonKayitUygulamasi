using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonKayitUygulamasi
{
    public partial class Radyo : Form
    {
        public Radyo()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://www.kralmuzik.com.tr/radyo/kral-pop";

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://www.youtube.com/watch?v=6He9sFxFv8Y";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://www.youtube.com/watch?v=8mlQS7R-c2g&list=PLKnjBHu2xXNN47QBOHJA-o8IK9AEN9C89&index=20";
        }
    }
}
