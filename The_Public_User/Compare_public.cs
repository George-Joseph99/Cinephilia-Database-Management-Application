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
    public partial class Compare_public : UserControl
    {
        Controller controllerObj;
        public Compare_public()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.movieslist();
            comboBox1.DataSource = dt;
            comboBox2.DataSource = dt;
            comboBox1.DisplayMember = "Title";
            comboBox2.DisplayMember = "Title";
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Compare_public_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataTable dt = controllerObj.movieslist();
            DataTable dt2 = controllerObj.movieslist();
            comboBox1.DataSource = dt;
            comboBox2.DataSource = dt2;
            comboBox1.DisplayMember = "Title";
            comboBox2.DisplayMember = "Title";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.moviedata(comboBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DataTable dt3 = controllerObj.genreofmovie(comboBox1.Text);
            dataGridView3.DataSource = dt3;
            dataGridView3.Refresh();
            DataTable dt4 = controllerObj.producersofmovie(comboBox1.Text);
            dataGridView4.DataSource = dt4;
            dataGridView4.Refresh();
            DataTable dt6 = controllerObj.moviedata(comboBox2.Text);
            dataGridView6.DataSource = dt6;
            dataGridView6.Refresh();
            DataTable dt5 = controllerObj.genreofmovie(comboBox2.Text);
            dataGridView5.DataSource = dt5;
            dataGridView5.Refresh();
            DataTable dt2 = controllerObj.producersofmovie(comboBox2.Text);
            dataGridView2.DataSource = dt2;
            dataGridView2.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
