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
    public partial class dirsearch1 : Form
    {
        string username;
        Controller controllerObj;
        public dirsearch1(string user)
        {
            InitializeComponent();
            username = user;
            controllerObj = new Controller();

        }

        private void dirsearch1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt2 = controllerObj.myawards(username);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }
    }
}
