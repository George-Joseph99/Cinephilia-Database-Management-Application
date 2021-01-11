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
    public partial class starsearch1 : Form
    {
        string username;
        Controller controllerObj;

        public starsearch1(string user)
        {
            InitializeComponent();
            username = user;
            controllerObj = new Controller();
        }

        private void starsearch1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.mytopratedmovies(username);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.myworstratedmovies(username); 
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.howmanyrated(username);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
