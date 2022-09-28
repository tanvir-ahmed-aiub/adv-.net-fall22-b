using Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Course c) {
            if (ModelState.IsValid) {
                return RedirectToAction("Index", "Home");
            }
            return View(c);
        }
        //public ActionResult Submit(Course c) {
        //    // ViewBag.Name = Request["Name"];
        //    //ViewBag.Name = form["Name"];
        //    //ViewBag.Name = c.Name;
        //    return View(c);
        //}
    }
}