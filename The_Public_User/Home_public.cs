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
    public partial class Home_public : UserControl
    {
        Controller controllerObj;
        public Home_public()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.selectnew5();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DataTable dt2 = controllerObj.toprated5();
            dataGridView2.DataSource = dt2;
            dataGridView2.Refresh();
            DataTable dt3 = controllerObj.topgross();
            dataGridView3.DataSource = dt3;
            dataGridView3.Refresh();
            textBox1.Text = controllerObj.randomquote();
            textBox2.Text = controllerObj.movieq(textBox1.Text);
        }
    }
}
