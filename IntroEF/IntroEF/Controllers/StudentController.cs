using IntroEF.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            //retrv from db
            var db = new UMS_bEntities();
            var students = db.Students.ToList();
            return View(students);
        }
        [HttpGet]
        public ActionResult Create() { 
            return View();  
        }
        [HttpPost]
        public ActionResult Create(Student student) {
            //add to db
            var db = new UMS_bEntities();
            db.Students.Add(student);
            db.SaveChanges();
            TempData["msg"] = "Entry Inserted Successfully";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id) {
            var db = new UMS_bEntities();
            var ext=(from st in db.Students
                    where st.Id == id   
                    select st).SingleOrDefault();
             return View(ext);

        }
        [HttpPost]
        public ActionResult Edit(Student formStu) {
            var db = new UMS_bEntities();
            var ext = (from st in db.Students
                       where st.Id == formStu.Id
                       select st).FirstOrDefault();
            /*ext.Name = formStu.Name;
            ext.Dob = formStu.Dob;
            ext.Cgpa = formStu.Cgpa;
            db.SaveChanges();*/
            formStu.Age = ext.Age;
            db.Entry(ext).CurrentValues.SetValues(formStu);
            db.SaveChanges();
            TempData["msg"] = "Entry Updated Successfully";
            return RedirectToAction("Index");

        }

        // find ext object
        //db.Studens.Remove(ext);
        //db.SaveChanges();
    }
}