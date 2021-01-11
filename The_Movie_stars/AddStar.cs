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
    public partial class AddStar : UserControl
    {
        Controller controllerObj;
        string username;
        public AddStar()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.movieslist();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Title";
        }

        private void AddStar_Load(object sender, EventArgs e)
        {

        }
        public void setusername(string user)
        {
            username = user;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int result1 = controllerObj.Insertmovie(textBox1.Text, Int16.Parse(textBox2.Text), Int16.Parse(textBox11.Text), Int16.Parse(textBox12.Text), textBox6.Text, "", textBox5.Text, textBox3.Text, textBox4.Text);
            if (result1 ==1)
            {
                int result2 = controllerObj.insertgenre(textBox1.Text, textBox8.Text);
                int result3 = controllerObj.insertgenre(textBox1.Text, textBox9.Text);
                int result4 = controllerObj.insertgenre(textBox1.Text, textBox10.Text);
                int result5 = controllerObj.linkstar(username, textBox1.Text, textBox13.Text);
                if (result2 == 1 && result3 == 1 && result4 == 1 && result5 == 1)
                    MessageBox.Show("Movie Inserted succefully and you are linked yo it");
                else
                    MessageBox.Show("Make Sure that the title is not slrady insertd");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result1 = controllerObj.linkstar(username, comboBox1.Text, textBox13.Text);
            if (result1 == 1)
                MessageBox.Show("LINK DONE ,  your are now from the cast");
            else
                MessageBox.Show("LINK Failed MAKE SURE YOU CHOSE A MOVIE");
        }
    }
}
