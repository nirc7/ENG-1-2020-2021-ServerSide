using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            lblResult.Text =  Caclculate("add").ToString();
        }

        private double Caclculate(string op)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double result = 0;

            switch (op)
            {
                case "add":
                    result =  num1 + num2;
                    break;
                case "sub":
                    result = num1 - num2;
                    break;
                case "mul":
                    result = num1 * num2;
                    break;
                case "div":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("divide by zero!!!");
                    }
                    break;
            }

            return result;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            lblResult.Text = Caclculate("sub").ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            lblResult.Text = Caclculate("mul").ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            lblResult.Text = Caclculate("div").ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("WELCOME TO MY CALCULATOR");
        }

        
       
    }
}
