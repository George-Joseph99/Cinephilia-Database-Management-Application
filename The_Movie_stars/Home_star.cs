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
    public partial class Home_star : UserControl
    {
        string username;
        Controller controllerObj;
        public Home_star()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_star_Load(object sender, EventArgs e)
        {

        }
        public void setusername(string user)
        {
            username = user;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.mytopratedmovies(username);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DataTable dt2 = controllerObj.mytopgross(username);
            dataGridView2.DataSource = dt2;
            dataGridView2.Refresh();
            DataTable dt4 = controllerObj.myawards(username);
            dataGridView4.DataSource = dt4;
            dataGridView4.Refresh();
            int total = controllerObj.totalminacting(username);
            textBox2.Text = total.ToString();
            textBox1.Text = (total / 60).ToString();
            textBox3.Text = (total * 60).ToString();
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }
    }
}
