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
    public partial class comparedirector : UserControl
    {
        string user_id;
        Controller controllerObj;
        public comparedirector()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comparedirector_Load(object sender, EventArgs e)
        {

        }
        public void setuser_id(string user)
        {
            user_id = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result1 = controllerObj.addcompany(textBox3.Text, textBox2.Text);
            int result2 = controllerObj.addhead(textBox3.Text, textBox1.Text);
            int result3 = controllerObj.addhead(textBox3.Text, textBox4.Text);
            int result4 = controllerObj.addhead(textBox3.Text, textBox5.Text);
            if (result1 == 1)
                MessageBox.Show("company added!");
            else
                MessageBox.Show("Company not added");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.movieslist();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
            DataTable dt2 = controllerObj.prodlist();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = controllerObj.linkcompany(comboBox1.Text, comboBox2.Text);
            if (result == 1)
                MessageBox.Show("company linked succefully");
        }
    }
}
