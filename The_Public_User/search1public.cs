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
    public partial class search1public : Form
    {
        Controller controllerObj;
        public search1public()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void search1public_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.topratedgenre(comboBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.genrelist(); 
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "movie_type";
            controllerObj = new Controller();
            DataTable dt2 = controllerObj.dislist();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt2 = controllerObj.moviefromdist(comboBox2.Text);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }
    }
}
