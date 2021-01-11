using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    
    public partial class reportStar : UserControl
    {
        string username;
        Controller controllerObj;
        public reportStar()
        {
            InitializeComponent();
        }

        private void reportStar_Load(object sender, EventArgs e)
        {

        }
        public void setusername(string user)
        {
            username = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.awardslist();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = controllerObj.linkaward(username, comboBox1.Text, Int16.Parse(textBox1.Text));
            if (result == 1)
                MessageBox.Show("Link done");
            else
                MessageBox.Show("link failed");
        }
    }
}

