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
    public partial class searchadmin : UserControl
    {
        Controller controllerObj;
        public searchadmin()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void searchadmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Allmovies();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.AllPeople();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.AllUsers();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.AllProduction();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Allstars();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Alldirectors();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Allrating();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
