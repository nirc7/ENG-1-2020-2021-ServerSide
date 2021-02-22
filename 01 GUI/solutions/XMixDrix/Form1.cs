using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace XMixDrix
{
    public partial class Form1 : Form
    {
        bool sign = true;
        bool gameOver = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (button1.Text == "?")
                {
                    button1.Text = convertSign(); 
                    CheckWin();
                    sign = !sign;
                }
            }
        }

       

        private void CheckWin() 
        {
            if ( ( (button1.Text == button2.Text) && button3.Text == button1.Text && button1.Text !="?") ||
                (button4.Text == button5.Text && button6.Text == button4.Text && button4.Text != "?") ||
                button9.Text == button8.Text && button7.Text == button8.Text && button7.Text != "?")
            {
                MessageBox.Show(convertSign() +  " wins throught a LINE!");
                gameOver = true;
            }
            else if (button1.Text == button6.Text && button9.Text == button1.Text && button1.Text != "?" ||
                button2.Text == button5.Text && button2.Text == button8.Text && button8.Text != "?" ||
                button3.Text == button4.Text && button7.Text == button3.Text && button3.Text != "?")
            {
                MessageBox.Show(convertSign() + " wins throught a ROW!");
                gameOver = true;
            }
            else if (button1.Text == button5.Text && button7.Text == button1.Text && button1.Text != "?" ||
               button9.Text == button5.Text && button9.Text == button3.Text && button3.Text != "?")
            {
                MessageBox.Show(convertSign() + " wins throught a DIAGONAL!");
                gameOver = true;
            }
        }

        private string convertSign()
        {
            if (sign)
            {
                return "X";
            }
            return "O";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (button2.Text == "?")
                {
                    if (sign)
                    {
                        button2.Text = "X";
                    }
                    else
                    {
                        button2.Text = "O";
                    }
                    CheckWin();
                    sign = !sign;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (button3.Text == "?")
                {
                    if (sign)
                    {
                        button3.Text = "X";
                    }
                    else
                    {
                        button3.Text = "O";
                    }
                    CheckWin();
                    sign = !sign;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (button6.Text == "?")
                {
                    if (sign)
                    {
                        button6.Text = "X";
                    }
                    else
                    {
                        button6.Text = "O";
                    }
                    CheckWin();
                    sign = !sign;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (button5.Text == "?")
                {
                    if (sign)
                    {
                        button5.Text = "X";
                    }
                    else
                    {
                        button5.Text = "O";
                    }
                    CheckWin();
                    sign = !sign;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (button4.Text == "?")
                {
                    if (sign)
                    {
                        button4.Text = "X";
                    }
                    else
                    {
                        button4.Text = "O";
                    }
                    CheckWin();
                    sign = !sign;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (button9.Text == "?")
                {
                    if (sign)
                    {
                        button9.Text = "X";
                    }
                    else
                    {
                        button9.Text = "O";
                    }
                    CheckWin();
                    sign = !sign;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (button8.Text == "?")
                {
                    if (sign)
                    {
                        button8.Text = "X";
                    }
                    else
                    {
                        button8.Text = "O";
                    }
                    CheckWin();
                    sign = !sign;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (button7.Text == "?")
                {
                    if (sign)
                    {
                        button7.Text = "X";
                    }
                    else
                    {
                        button7.Text = "O";
                    }
                    CheckWin();
                    sign = !sign;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            gameOver = false;
            sign = true;
            button1.Text = "?";
            button2.Text = "?";
            button3.Text = "?";
            button4.Text = "?";
            button5.Text = "?";
            button6.Text = "?";
            button7.Text = "?";
            button8.Text = "?";
            button9.Text = "?";

            //Thread.Sleep(2000);
        }
    }
}
