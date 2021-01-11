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
    public partial class changepassword : Form
    {
        string username;
        public changepassword(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void changepassword_Load(object sender, EventArgs e)
        {

        }
    }
}
