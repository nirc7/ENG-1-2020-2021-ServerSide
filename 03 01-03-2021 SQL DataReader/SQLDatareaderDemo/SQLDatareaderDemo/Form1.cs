using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDatareaderDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ExcNQ($"INSERT INTO TBUsers(NAME, FAMILY) VALUES('{txtName.Text}', '{txtFamily.Text}')");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExcNQ($" DELETE TBUsers" +
                    $" WHERE ID={txtId.Text}");
        }

        private void ExcNQ(string commTXT)
        {
            string conStr = @"Data Source=E440\SQLEXPRESS;Initial Catalog=DBUsers;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            //SqlCommand comm = new SqlCommand("INSERT INTO TBUsers(NAME, FAMILY) VALUES('" + txtName.Text + "', '" + txtFamily.Text + "')", con);
            SqlCommand comm = new SqlCommand(commTXT, con);
            con.Open();//opt1
            //comm.Connection.Open();//opt2
            int res = comm.ExecuteNonQuery(); // Insert, Update, Delete
            con.Close();

            ShowTBUsers();

            MessageBox.Show((res == 1 ? "" : "not") + "succeeded!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ExcNQ($" UPDATE TBUsers " +
                    $" Set Name='{txtName.Text}' , Family='{txtFamily.Text}'" +
                    $" WHERE Id={txtId.Text}");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ShowTBUsers();
            ShowGV();
        }

        private void ShowTBUsers()
        {
            string orderby;
            if (rdbID.Checked)
                orderby = "ID";
            else if (rdbName.Checked)
                orderby = "NAME";
            else
                orderby = "Family";

            string output = "";
            string conStr = @"Data Source=E440\SQLEXPRESS;Initial Catalog=DBUsers;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand comm = new SqlCommand(
                 " SELECT * " +
                 " FROM TBUsers " +
                $" Order By {orderby}", con);
            con.Open();//opt1

            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                output += reader[0] + ", " + reader["Name"] + ", " + reader["Family"] + "\n";
            }

            con.Close();
            lblUsers.Text = output;
            File.WriteAllText("output.txt", output);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTBUsers();
            ShowGV();
        }

        private void ShowGV()
        {
            string orderby;
            if (rdbID.Checked)
                orderby = "ID";
            else if (rdbName.Checked)
                orderby = "NAME";
            else
                orderby = "Family";

            string conStr = @"Data Source=E440\SQLEXPRESS;Initial Catalog=DBUsers;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand comm = new SqlCommand(
                 " SELECT * " +
                 " FROM TBUsers " +
                $" Order By {orderby}", con);
            con.Open();//opt1
            SqlDataReader reader = comm.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            //GVUsers.AutoGenerateColumns = True;
            GVUsers.DataSource = dt;
            //GVUsers.Refresh();


            con.Close();
        }
    }
}
