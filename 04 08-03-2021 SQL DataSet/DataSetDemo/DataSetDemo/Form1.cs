using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDemo
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=E440\SQLEXPRESS;Initial Catalog=DBUsers;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adptr;
        DataSet dsUsers;
        DataTable dtUsers;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsUsers = new DataSet();

            con = new SqlConnection(strCon);
            adptr = new SqlDataAdapter(
                " SELECT * " +
                " FROM TBUsers " +
                " Order By Name ", con);

            FillDSAndDT();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FillDSAndDT();
        }

        private void FillDSAndDT()
        {
            dsUsers.Clear();
            adptr.Fill(dsUsers, "Users1");
            dtUsers = dsUsers.Tables["Users1"];

            //MessageBox.Show(dtUsers.Rows[0][1].ToString());
            dataGridView1.DataSource = dtUsers;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = dtUsers.NewRow();
            dr["Name"] = txtName.Text;
            dr["Family"] = txtFamily.Text;
            dr["ID"] = 7;

            dtUsers.Rows.Add(dr);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dtUsers.Rows)
            {
                if (row.RowState != DataRowState.Deleted && row["ID"].ToString() == txtID.Text)
                {
                    row["Name"] = txtName.Text;
                    row["Family"] = txtFamily.Text;
                    row["ID"] = 777;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dtUsers.Rows)
            {
                if (row.RowState != DataRowState.Deleted && row["ID"].ToString() == txtID.Text)
                {
                    row.Delete();
                }
            }
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            new SqlCommandBuilder(adptr);
            adptr.Update(dtUsers);
        }

        private void btnDeleteWParams_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand(
                " DELETE From TBUsers " +
                " WHERE ID = @ParID", con);
            
            //SqlParameter parI = new SqlParameter("ParID", txtID.Text);
            //comm.Parameters.Add(parI);

            //SqlParameter parI2 = new SqlParameter("ParID", SqlDbType.Int);
            //parI2.Value = txtID.Text;

            comm.Parameters.Add(new SqlParameter("ParID", txtID.Text));

            comm.Connection.Open();
            int res = comm.ExecuteNonQuery();
            comm.Connection.Close();

            MessageBox.Show(res.ToString());
        }

        private void btnSPrValue_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("SearchUser", con);
            comm.CommandType = CommandType.StoredProcedure;

            SqlParameter parID = new SqlParameter("MyID", txtID.Text);
            parID.Direction = ParameterDirection.Input;
            comm.Parameters.Add(parID);

            SqlParameter parFamilyName = new SqlParameter("FamilyName",SqlDbType.VarChar,20);
            parFamilyName.Direction = ParameterDirection.Output;
            comm.Parameters.Add(parFamilyName);

            SqlParameter parErr = new SqlParameter();
            parErr.Direction = ParameterDirection.ReturnValue;
            comm.Parameters.Add(parErr);

            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();

            if ((int)parErr.Value == 0)
                MessageBox.Show(parFamilyName.Value.ToString());
            else
                MessageBox.Show("ERROR OCCURDED");   
        }

        private void btnSPrTable_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("SearchUserTable", con);
            comm.CommandType = CommandType.StoredProcedure;

            SqlParameter parID = new SqlParameter("MyID", txtID.Text);
            parID.Direction = ParameterDirection.Input;
            comm.Parameters.Add(parID);
                       
            SqlDataAdapter aptr2 = new SqlDataAdapter(comm);
            DataSet ds2 = new DataSet();
            aptr2.Fill(ds2, "T1");

            dataGridView1.DataSource = ds2.Tables["T1"];
        }
    }
}
