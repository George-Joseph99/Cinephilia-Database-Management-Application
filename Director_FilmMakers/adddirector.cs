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
    
    public partial class adddirector : UserControl
    {
        string user_id;
        Controller controllerObj;
        public adddirector()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void adddirector_Load(object sender, EventArgs e)
        {

        }
        public void setuser_id(string user)
        {
            user_id = user;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.movieslist();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.linkdirector(user_id,comboBox1.Text);
            if (result == 1)
                MessageBox.Show("Your are succefully linked to the movie");
            else
                MessageBox.Show("Link Failed!");
        }
    }
}
