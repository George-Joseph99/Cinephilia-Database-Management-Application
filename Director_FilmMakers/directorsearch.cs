using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication.Director_FilmMakers
{
    public partial class directorsearch : UserControl
    {
        string user_id;
        public directorsearch()
        {
            InitializeComponent();
        }
        public void setuser_id(string user)
        {
            user_id = user;
        }
        private void directorsearch_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form tmp = new dirsearch1(user_id);
            tmp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form tmp = new dirsearch2(user_id);
            tmp.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form tmp = new dirsearch3(user_id);
            tmp.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form tmp = new dirsearch4(user_id);
            tmp.Show();

        }
    }
}
