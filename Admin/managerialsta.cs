using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication.Admin
{
    public partial class managerialsta : UserControl
    {
        Controller controllerObj;
        public managerialsta()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = controllerObj.manyactors().ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = controllerObj.manydirectors().ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = controllerObj.manypublic().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = controllerObj.countusers().ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox5.Text = ((Int16.Parse(textBox1.Text) / Int16.Parse(textBox4.Text)) * 100).ToString();
            textBox6.Text = ((Int16.Parse(textBox2.Text) / Int16.Parse(textBox4.Text)) * 100).ToString();
            textBox7.Text = ((Int16.Parse(textBox3.Text) / Int16.Parse(textBox4.Text)) * 100).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.toprated5();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.lowrated5();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox8.Text = controllerObj.totalrates().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox9.Text = controllerObj.avgnet().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.usersthatratedmost();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void managerialsta_Load(object sender, EventArgs e)
        {

        }
    }
}
