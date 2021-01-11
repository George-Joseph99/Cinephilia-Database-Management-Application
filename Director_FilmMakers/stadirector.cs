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
    public partial class stadirector : UserControl
    {
        string user_id;
        public stadirector()
        {
            InitializeComponent();
        }
        public void setuser_id(string user)
        {
            user_id = user;
        }

        private void stadirector_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
