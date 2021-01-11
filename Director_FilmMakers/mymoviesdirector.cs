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
    public partial class mymoviesdirector : UserControl
    {
        Controller controllerObj;
        string user_id;
        public mymoviesdirector()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void mymoviesdirector_Load(object sender, EventArgs e)
        {

        }
        public void setuser_id(string user)
        {
            user_id = user;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.movieslist();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
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
            int result = controllerObj.rateadd(comboBox1.Text, user_id, rate);
            MessageBox.Show("Your rate has been recorded,Thank you");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.mymoviesdir(user_id);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
