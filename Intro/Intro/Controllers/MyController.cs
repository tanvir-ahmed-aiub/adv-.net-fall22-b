using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Intro() {
            ViewBag.Section = "B";
            ViewData["course"] = "Adv Web";
            return View();
        }
        public ActionResult Outro() {
            //ViewBag.Content = new { Course = "Adv .Net", Section = "B" };
            ViewBag.Section = "OK";
            return View();
        }
        public ActionResult Students() {
            ViewBag.Students = new String[] { "Sabbir", "Jamshed", "Rakib", "Arif", "Islam", "Pranty", "Nafisa" };
            return View();
        }
        public ActionResult Portal() {
            return Redirect("https://www.aiub.edu");
        }
        public ActionResult Home() {
            TempData["CourseTeacher"] = "Tanvir Ahmed";
            return RedirectToAction("Intro");

           // return RedirectToAction("About", "Home");

        }

    }
}