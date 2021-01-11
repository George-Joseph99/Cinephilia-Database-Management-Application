using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{

    public partial class stastars : UserControl
    {
        string username;
        Controller controllerObj;
        public stastars()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.mymovies(username);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
        }

        private void stastars_Load(object sender, EventArgs e)
        {

        }
        public void setusername(string user)
        {
            username = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.Updatemovie(textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox9.Text, textBox8.Text, textBox5.Text, comboBox1.Text);
            if (result == 1)
                MessageBox.Show("MOVIE UPDATED SUCCEFULLY");
            else
                MessageBox.Show("UPDATE FAILED NO MOVIE WITH THIS TITLE");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.mymovies(username);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
        }
    }
}
