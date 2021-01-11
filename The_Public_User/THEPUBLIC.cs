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
    public partial class THEPUBLIC : Form
    {
        string user_name;
        Form MyParent;
        public THEPUBLIC(string user,Form P)
        {
            user_name = user;
            MyParent = P;
            InitializeComponent();
        }
        private void THEPUBLIC_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyParent.Close();
        }
        private void THEPUBLIC_Load(object sender, EventArgs e)
        {
            settings1.Hide();
            searchPublic1.Hide();
            compare_public1.Hide();
            statisticsPublic1.Hide();
            reportsPublic1.Hide();
            addPublic1.Hide();
            home_public1.BringToFront();
            home_public1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            addPublic1.Hide();
            compare_public1.Hide();
            home_public1.Hide();
            reportsPublic1.Hide();
            settings1.Hide();
            statisticsPublic1.Hide();
            searchPublic1.BringToFront();
            searchPublic1.Show();
            //page11.Hide();
            //page2add1.Hide();
            //page3update1.Hide();
            //page4DepList1.Hide();
            //page5project1.BringToFront();
            //page5project1.Show();
            //page6delete1.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addPublic1.Hide();
            home_public1.Hide();
            reportsPublic1.Hide();
            settings1.Hide();
            statisticsPublic1.Hide();
            searchPublic1.Hide();
            compare_public1.BringToFront();
            compare_public1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addPublic1.Hide();
            home_public1.Hide();
            reportsPublic1.Hide();
            settings1.Hide();
            searchPublic1.Hide();
            compare_public1.Hide();
            statisticsPublic1.BringToFront();
            statisticsPublic1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addPublic1.Hide();
            home_public1.Hide();
            settings1.Hide();
            searchPublic1.Hide();
            compare_public1.Hide();
            statisticsPublic1.Hide();
            reportsPublic1.BringToFront();
            reportsPublic1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addPublic1.setuser_id(user_name);
            home_public1.Hide();
            settings1.Hide();
            searchPublic1.Hide();
            compare_public1.Hide();
            statisticsPublic1.Hide();
            reportsPublic1.Hide();
            addPublic1.BringToFront();
            addPublic1.Show();
            addPublic1.setuser_id(user_name);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyParent.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void home_public1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            settings1.Hide();
            searchPublic1.Hide();
            compare_public1.Hide();
            statisticsPublic1.Hide();
            reportsPublic1.Hide();
            addPublic1.Hide();
            home_public1.BringToFront();
            home_public1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            changepassword p = new changepassword(user_name);
            p.Show();

        }
    }
}
