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
    
    public partial class Mymoviesstar : UserControl
    {
        string username;
        Controller controllerObj;
        public Mymoviesstar()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.movieslist();  
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
        }

        private void Mymoviesstar_Load(object sender, EventArgs e)
        {

        }
        public void setusername(string user)
        {
            username = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.mymovies(username);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rate;
            if (radioButton1.Checked == true)
                rate = 1;
            else if (radioButton2.Checked == true)
                rate = 2;
            else if (radioButton3.Checked == true)
                rate = 3;
            else if (radioButton4.Checked == true)
                rate = 4;
            else if (radioButton5.Checked == true)
                rate = 5;
            else
            {
                MessageBox.Show("Rating failed ,choose 1 ->>> 5");
                return;
            }
            int result = controllerObj.rateadd(comboBox1.Text, username, rate);
            MessageBox.Show("Your rate has been recorded,Thank you");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.movieslist();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
        }
    }
}
