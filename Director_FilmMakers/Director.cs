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
    public partial class Director : Form
    {
        string username;
        Form MyParent;
        public Director(string user,Form P)
        {
            username = user;
            MyParent = P;
            InitializeComponent();
        }
        private void Director_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyParent.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Director_Load(object sender, EventArgs e)
        {
            adddirector1.Hide();
            stadirector1.Hide();
            mymoviesdirector1.Hide();
            directorreport1.Hide();
            comparedirector1.Hide();
            homedirector1.Hide();
            directorsearch1.BringToFront();
            directorsearch1.Show();
            directorsearch1.setuser_id(username);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            adddirector1.Hide();
            stadirector1.Hide();
            mymoviesdirector1.Hide();
            directorreport1.Hide();
            comparedirector1.Hide();
            homedirector1.Hide();
            directorsearch1.BringToFront();
            directorsearch1.Show();
            directorsearch1.setuser_id(username);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            adddirector1.Hide();
            stadirector1.Hide();
            mymoviesdirector1.Hide();
            directorreport1.Hide();
            homedirector1.Hide();
            directorsearch1.Hide();
            comparedirector1.BringToFront();
            comparedirector1.Show();
            comparedirector1.setuser_id(username);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            adddirector1.Hide();
            mymoviesdirector1.Hide();
            directorreport1.Hide();
            homedirector1.Hide();
            directorsearch1.Hide();
            comparedirector1.Hide();
            stadirector1.BringToFront();
            stadirector1.Show();
            stadirector1.setuser_id(username);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            adddirector1.Hide();
            mymoviesdirector1.Hide();
            homedirector1.Hide();
            directorsearch1.Hide();
            comparedirector1.Hide();
            stadirector1.Hide();
            directorreport1.BringToFront();
            directorreport1.Show();
           

        }

        private void button14_Click(object sender, EventArgs e)
        {
            mymoviesdirector1.Hide();
            homedirector1.Hide();
            directorsearch1.Hide();
            comparedirector1.Hide();
            stadirector1.Hide();
            directorreport1.Hide();
            adddirector1.BringToFront();
            adddirector1.Show();
            adddirector1.setuser_id(username);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            homedirector1.Hide();
            directorsearch1.Hide();
            comparedirector1.Hide();
            stadirector1.Hide();
            directorreport1.Hide();
            adddirector1.Hide();
            mymoviesdirector1.BringToFront();
            mymoviesdirector1.Show();
            mymoviesdirector1.setuser_id(username);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            adddirector1.Hide();
            stadirector1.Hide();
            mymoviesdirector1.Hide();
            directorreport1.Hide();
            comparedirector1.Hide();
            homedirector1.Hide();
            directorsearch1.BringToFront();
            directorsearch1.Show();
            directorsearch1.setuser_id(username);
        }

        private void directorsearch1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyParent.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            changepassword p = new changepassword(username);
            p.Show();
        }
    }
}
