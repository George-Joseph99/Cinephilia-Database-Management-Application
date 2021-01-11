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
    public partial class search2public : Form
    {
        Controller controllerObj;
        public search2public()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void search2public_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.actorslist(); 
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Person_name";
            controllerObj = new Controller();
            DataTable dt2 = controllerObj.directorslist();  
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Person_name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmp = comboBox1.Text;
            string[] tmp2 = tmp.Split(' ');
            DataTable dt2 = controllerObj.getawradsfromname(tmp2[0],tmp2[1],tmp2[2]);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = comboBox2.Text;
            string[] tmp2 = tmp.Split(' ');
            DataTable dt2 = controllerObj.getawradsfromname(tmp2[0], tmp2[1], tmp2[2]);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }
    }
}
