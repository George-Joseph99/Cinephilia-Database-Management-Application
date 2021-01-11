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
    public partial class AddMovie : UserControl
    {
        Controller controllerObj;
        public AddMovie()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int result1 = controllerObj.Insertmovie(textBox1.Text, Int16.Parse(textBox2.Text), Int16.Parse(textBox11.Text), Int16.Parse(textBox12.Text),
                textBox6.Text, "", textBox5.Text, textBox3.Text, textBox4.Text);
        }
    }
}
