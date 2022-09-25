using Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = new List<Student>();
            for(int i = 1; i <= 10; i++)
            {
                Student s1 = new Student()
                {
                    Id = i,
                    Name = "Tanvir Ahmed _ "+i,
                    Dob = "12.12.12.",
                    Cgpa = "2.45",
                    Address = "Dhaka"
                };
                students.Add(s1);
            }
            return View(students);
        }
        public ActionResult Profile() {
            Student s1 = new Student() {
                Id = 1,
                Name = "Tanvir Ahmed",
                Dob = "12.12.12.",
                Cgpa = "2.45",
                Address = "Dhaka"
            };
            return View(s1);
        }
    }
}