using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello " + txtName.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblHello.Text = txtName.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblHello.Text = checkBox1.Checked ? "yes" : "No";
        }
        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblHello.Text =  DateTime.Now.AddDays(5).DayOfWeek + ", ";
            lblHello.Text += monthCalendar1.SelectionStart.ToShortDateString()+ ", ";
            lblHello.Text += DateTime.Now.ToShortTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Pip Pip!";
        }

        private void cmbCounting_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHello.Text = cmbCounting.SelectedItem + ", " + cmbCounting.SelectedIndex;
        }
    }
}
