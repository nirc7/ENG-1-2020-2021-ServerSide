using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentsController : ApiController
    {
        public IEnumerable<Student> Get()
        {
            return StudentsDBMOCK.students;
        }

        public Student Get(int id)
        {
            //IEnumerable<Student> is2 = StudentsDBMOCK.students.Where(stu => stu.Name.Contains("avi"));
            return StudentsDBMOCK.students.SingleOrDefault(stu => stu.ID == id);

        }
    }
}
