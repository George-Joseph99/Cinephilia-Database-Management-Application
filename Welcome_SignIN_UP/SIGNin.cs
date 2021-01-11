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
    public partial class SIGNin : Form
    {
        Form MyParent;
        Controller controllerObj;
        
        public SIGNin(Form P)
        {
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();
            controllerObj = new Controller();
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SIGNin_Load(object sender, EventArgs e)
        {

        }
        private void SIGNin_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyParent.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int type = controllerObj.signintype(textBox1.Text, textBox2.Text);
            if (type == 1)
            {
                this.Hide();
                MAIN_ADMINS b = new MAIN_ADMINS();
                b.Show();
            }
            else if (type == 2)
            {
                this.Hide();
                ACTOR b = new ACTOR(textBox1.Text, MyParent);
                b.Show();
            }
            else if (type == 3)
            {
                this.Hide();
                Director b = new Director(textBox1.Text, MyParent);
                b.Show();

            }
            else if (type == 4)
            {
                this.Hide();
                THEPUBLIC b = new THEPUBLIC(textBox1.Text, MyParent);
                b.Show();
            }
            else
                MessageBox.Show("User not Found or Wrong password");
                        
            }
    }
}
