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
    public partial class SIGNupp : Form
    {
        Form MyParent;
        Controller controllerObj;
        public SIGNupp(Form P)
        {
            InitializeComponent();
            controllerObj = new Controller();
            MyParent = P;
            MyParent.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SIGNupp_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyParent.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result1 = controllerObj.InsertPerson(textBox7.Text, textBox8.Text, textBox9.Text, Int16.Parse(textBox11.Text), textBox13.Text, textBox10.Text, textBox12.Text, textBox21.Text);
            if (result1 == 1)
            {
                if (radioButton1.Checked == true)
                {
                    int result2 = controllerObj.Insertuser(4, textBox1.Text, textBox2.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
                    if (result2 == 1)
                    {
                        this.Hide();
                        THEPUBLIC b = new THEPUBLIC(textBox1.Text, MyParent);
                        b.Show();
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    int result2 = controllerObj.Insertuser(3, textBox1.Text, textBox2.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
                    if (result2 == 1)
                    {
                        this.Hide();
                        Director b = new Director(textBox1.Text, MyParent);
                        b.Show();
                    }
                
                }
                else if (radioButton3.Checked == true)
                {
                    int result2 = controllerObj.Insertuser(2, textBox1.Text, textBox2.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
                    if (result2 == 1)
                    {
                        this.Hide();
                        ACTOR b = new ACTOR(textBox1.Text, MyParent);
                        b.Show();
                    }
                }
                else
                    return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MAIN_ADMINS b = new MAIN_ADMINS();
            b.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void SIGNupp_Load(object sender, EventArgs e)
        {

        }
    }
}
