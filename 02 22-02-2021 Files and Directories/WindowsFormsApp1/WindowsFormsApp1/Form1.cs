using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string path = @"../../file1.txt";
        string studentPath = @"studentData.txt";
        List<Student> sl = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            File.AppendAllText(path, "Hello World\n");
        }

        private void btnRAllF_Click(object sender, EventArgs e)
        {
            string output = File.ReadAllText(path);
            lblRes.Text = output;
        }

        private void btnRLines_Click(object sender, EventArgs e)
        {
            //opt1
            int counter = 0;
            string output = "";
            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                output += counter++ + ". " + line + "\n";
            }

            lblRes.Text = output;

            ////opt2
            //int counter = 0;
            //string[] lines = File.ReadAllLines(path);
            //foreach (var line in lines)
            //{
            //    lblRes.Text += counter++ + ". " + line + "\n";
            //}
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            File.AppendAllText(studentPath, $"{txtName.Text}, {new Random().Next(60, 101)}\n");
        }

        private void btnGetStudents_Click(object sender, EventArgs e)
        {
            ShowAllStudent();
        }

        private void ShowAllStudent()
        {
            lblStudent.Text = "";
            foreach (var st in sl)
            {
                lblStudent.Text += st + "\n";
            }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
             lblStudent.Text = (sl.Sum(st => st.Grade)/ sl.Count).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllSitdentsFromFile();
        }

        private void GetAllSitdentsFromFile()
        {
            foreach (var line in File.ReadAllLines(studentPath))
            {
                string[] inputs = line.Split(',');
                string name = inputs[0];
                int grade = int.Parse(inputs[1]);
                sl.Add(new Student() { Name = name, Grade = grade });
            }
        }
    }
}
