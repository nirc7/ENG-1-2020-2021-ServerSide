using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnB1_Click(object sender, EventArgs e)
        {
            lblInFunction.Text = "btnB1_Click";
            txtInFunction.Text = sender.GetType().Name;
        }

        private void chkDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInFunction.Text = "chkB1_SelectedIndexChanged";
            txtInFunction.Text = sender.GetType().Name + "value: " + chkDM.SelectedValue + "index:" + chkDM.SelectedIndex;

            for (int i = 0; i < chkDM.Items.Count; i++ )
            {
                if (chkDM.CheckedItems.Contains(chkDM.Items[i]))
                    txtInFunction.Text += " " + chkDM.Items[i].ToString();
            }

            //foreach (Object item in chkTPM.Items)
            //{
            //    if (chkTPM.CheckedItems.Contains(item))
            //        txtInFunction.Text += " " + item.ToString();
            //}

            if (chkDM.CheckedItems.Contains(chkDM.Items[0]))
                txtInFunction.Text += " " + chkDM.Items[0].ToString();
        }

        private void chkWhat_CheckedChanged(object sender, EventArgs e)
        {
            lblInFunction.Text = "chkWhat_CheckedChanged";
            txtInFunction.Text = sender.GetType().Name;
            if (chkWhat.Checked)
                txtInFunction.Text += " Checked";
            else
                txtInFunction.Text += " Not Checked";
        }

        private void cboPixis_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInFunction.Text = "cboPixis_SelectedIndexChanged";
            txtInFunction.Text = sender.GetType().Name + " " + cboPixis.SelectedIndex + ": " + cboPixis.SelectedItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPixis.Items.Add("to");
            cboPixis.Items.Add("meet");
            cboPixis.Items.Add("you");
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblInFunction.Text = "DateTimePicker1_ValueChanged";
            txtInFunction.Text = sender.GetType().Name + "the day is: " + DateTimePicker1.Value.Day + " the time: " + DateTimePicker1.Value.Hour;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblInFunction.Text = "LinkLabel1_LinkClicked";
            txtInFunction.Text = sender.GetType().Name;

            if (picMypic.ImageLocation == @"..\..\..\mypic2.jpg")
                picMypic.ImageLocation = @"..\..\..\mypic1.jpg";
            else
                picMypic.ImageLocation = @"..\..\..\mypic2.jpg";

            MessageBox.Show(Application.StartupPath);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblInFunction.Text = "btnCheck_Click";
            txtInFunction.Text = sender.GetType().Name;
            if (RadioButton1.Checked)
                txtInFunction.Text += " radio1";
            else if (RadioButton2.Checked)
                txtInFunction.Text += " radio2";
            else if (RadioButton3.Checked)
                txtInFunction.Text += " radio3";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dr = MessageBox.Show("לקום!", "Hello", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading, true);

            if (dr == System.Windows.Forms.DialogResult.No)
                MessageBox.Show("you pressed no");
            else if (dr == System.Windows.Forms.DialogResult.Yes)
                MessageBox.Show("you pressed yes");
            //Else ' this is not a possibility because it doesnt close the message box at all
            //MessageBox.Show("you pressed help")


            Timer1.Enabled = false;
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            MessageBox.Show(MonthCalendar1.ToString());
            MessageBox.Show(e.Start.ToShortDateString());
            MessageBox.Show(MonthCalendar1.SelectionRange.Start.ToString());
            MessageBox.Show(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblInFunction.Text = "Button1_Click";
            txtInFunction.Text = ((Button)(sender)).Name + " , " + sender.ToString();
            //impossible this way (need reflection??)txtInFunction.Text += " , " + (Convert.ChangeType(sender,sender.GetType())).Name;
        }






    }
}