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
    public partial class starsearch2 : Form
    {
        string username;
        Controller controllerObj;
        public starsearch2(string user)
        {
            InitializeComponent();
            username = user;
            controllerObj = new Controller();
        }

        private void starsearch2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.mytopgross(username);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.mylowgross(username);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.mytotalgross(username);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
