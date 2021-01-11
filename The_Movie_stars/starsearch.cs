using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication.The_Movie_stars
{
    public partial class starsearch : UserControl
    {
        string username;
        public starsearch()
        {
            InitializeComponent();
        }

        private void starsearch_Load(object sender, EventArgs e)
        {

        }
        public void setusername(string user)
        {
            username = user;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form tmp = new starsearch1(username);
            tmp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form tmp = new starsearch2(username);
            tmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form tmp = new starsearch3(username);
            tmp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form tmp = new starsearch4(username);
            tmp.Show();
        }
    }
}
