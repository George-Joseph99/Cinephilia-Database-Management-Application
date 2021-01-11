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
    public partial class deleteUser : UserControl
    {
        Controller controllerObj;
        public deleteUser()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.AllUsers();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = controllerObj.Deleteuser(Int16.Parse(textBox8.Text));
            if (result == 1)
                MessageBox.Show("user deleted");
            else
                MessageBox.Show("user not deleted");
        }
    }
}
