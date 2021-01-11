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
    public partial class WELCOME_TO_CINEPHILIA : Form
    {
        public WELCOME_TO_CINEPHILIA()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WELCOME_TO_CINEPHILIA_Load(object sender, EventArgs e)
        {

        }

        

        private void PANEL_1_BOTTOM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel_MAIN_MENU_IMAGE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HELP_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FEEDBACK_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            SIGNupp b = new SIGNupp(this);
            b.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SIGNin a = new SIGNin(this);
            a.Show();
            
        }
    }
}
