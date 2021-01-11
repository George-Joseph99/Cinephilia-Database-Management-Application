using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication.The_Public_User
{
    public partial class search4public : Form
    {
        Controller controllerObj;
        public search4public()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void search4public_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.movieslist();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = controllerObj.getcompsername(comboBox1.Text);

            DataTable dt2 = controllerObj.getmoviesofcomposer(textBox1.Text);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }
    }
}
