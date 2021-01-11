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
    public partial class ACTOR : Form
    {
        string username;
        Form MyParent;

        public ACTOR(string user,Form P)
        {
            username = user;
            InitializeComponent();
            MyParent = P;

        }
        private void ACTOR_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyParent.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ACTOR_Load(object sender, EventArgs e)
        {
            starsearch1.Hide();
            compare_Stars1.Hide();
            stastars1.Hide();
            reportStar1.Hide();
            addStar1.Hide();
            mymoviesstar1.Hide();
            home_star1.BringToFront();
            home_star1.Show();
            home_star1.setusername(username);
        }

        private void button15_Click(object sender, EventArgs e)
        {

            addStar1.Hide();
            compare_Stars1.Hide();
            reportStar1.Hide();
            stastars1.Hide();
            home_star1.Hide();
            mymoviesstar1.Hide();
            starsearch1.BringToFront();
            starsearch1.Show();
            starsearch1.setusername(username);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addStar1.Hide();
            reportStar1.Hide();
            stastars1.Hide();
            home_star1.Hide();
            mymoviesstar1.Hide();
            starsearch1.Hide();
            compare_Stars1.BringToFront();
            compare_Stars1.Show();
            compare_Stars1.setusername(username);
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addStar1.Hide();
            reportStar1.Hide();
            home_star1.Hide();
            mymoviesstar1.Hide();
            starsearch1.Hide();
            compare_Stars1.Hide();
            stastars1.BringToFront();
            stastars1.Show();
            starsearch1.setusername(username);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            addStar1.Hide();
            home_star1.Hide();
            mymoviesstar1.Hide();
            starsearch1.Hide();
            compare_Stars1.Hide();
            stastars1.Hide();
            reportStar1.BringToFront();
            reportStar1.Show();
            reportStar1.setusername(username);

        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            home_star1.Hide();
            mymoviesstar1.Hide();
            starsearch1.Hide();
            compare_Stars1.Hide();
            stastars1.Hide();
            reportStar1.Hide();
            addStar1.BringToFront();
            addStar1.Show();
            addStar1.setusername(username);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home_star1.Hide();
            starsearch1.Hide();
            compare_Stars1.Hide();
            stastars1.Hide();
            reportStar1.Hide();
            addStar1.Hide();
            mymoviesstar1.BringToFront();
            mymoviesstar1.Show();
            mymoviesstar1.setusername(username);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            starsearch1.Hide();
            compare_Stars1.Hide();
            stastars1.Hide();
            reportStar1.Hide();
            addStar1.Hide();
            mymoviesstar1.Hide();
            home_star1.BringToFront();
            home_star1.Show();
            home_star1.setusername(username);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyParent.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            changepassword p = new changepassword(username);
            p.Show();
        }
    }
}
