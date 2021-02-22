using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "avi@a.com" && txtPass.Text == "123")
            {
                lblRes.Text = "successeded";
                lblRes.ForeColor = Color.Green;
            }
            else
            {
                lblRes.Text = "worng pass or email!";
                lblRes.ForeColor = Color.Red;
            }
        }
    }
}
