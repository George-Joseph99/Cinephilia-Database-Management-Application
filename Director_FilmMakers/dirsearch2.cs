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
    public partial class dirsearch2 : Form
    {
        string username;
        Controller controllerObj;
        public dirsearch2(string user)
        {
            InitializeComponent();
            username = user;
            controllerObj = new Controller();
        }

        private void dirsearch2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt2 = controllerObj.mystars(username);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }
    }
}
