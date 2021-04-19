using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public static class StudentsDB
    {
        public static List<Student> GetAllStudents()
        {
            //string conStr = @"Data Source=E440\SQLEXPRESS;Initial Catalog=DBStudents;Integrated Security=True";
            return ExecQ("SELECT * FROM TBStudents");

        }

        private static List<Student> ExecQ(string query)
        {
            string conStr = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter adptr = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adptr.Fill(ds);
            List<Student> ls = new List<Student>();

            //opt1
            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //    ls.Add(new Student()
            //    {
            //        ID = (int)row["ID"],
            //        Name = (string)row["Name"],
            //        Grade = (int)row["Grade"]
            //    });
            //}

            //opt2
            ls = ds.Tables[0].AsEnumerable()
                .Select(stu => new Student()
                {
                    ID = stu.Field<int>("ID"),
                    Name = stu.Field<string>("Name"),
                    Grade = stu.Field<int>("Grade"),

                }).ToList<Student>();

            return ls;
        }
    }
}