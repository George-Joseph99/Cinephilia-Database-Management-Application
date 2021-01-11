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
    public partial class directorreport : UserControl
    {
        Controller controllerObj;
        public directorreport()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.movieslist();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
            controllerObj = new Controller();
            DataTable dt2 = controllerObj.getcomplist();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "composer";

        }

        private void directorreport_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt2 = controllerObj.getmoviesofcomposer(comboBox2.Text);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = controllerObj.addcomp(comboBox1.Text, textBox1.Text);
            if (result == 1)
                MessageBox.Show("Your Composer was added succefully");
            else
                MessageBox.Show("Insertion failed");
        }
    }
}
