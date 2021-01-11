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
    public partial class starsearch4 : Form
    {
        string username;
        Controller controllerObj;
        public starsearch4(string user)
        {
            InitializeComponent();
            username = user;
            controllerObj = new Controller();
        }

        private void starsearch4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.myawards(username);  
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
