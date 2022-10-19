using Association.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Association.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet]
        public ActionResult Index()
        {
            var db = new UMSfall22_bEntities();
            return View(db.Courses.ToList());
        }
        [HttpPost]
        public ActionResult Index(int[] courses,string btn_submit) {
            var db = new UMSfall22_bEntities();
            foreach (var cid in courses) {
                db.CourseStudents.Add(new CourseStudent() { 
                
                    CourseId = cid,
                    StudentId = 1

                });
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}