using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroHungerMVC.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Default
        public ActionResult Ngo()
        {
            return View(CollectionReqService.Get());
        }
        public ActionResult Emp() {
            var logged = Session["logged"].ToString();
            var data = CollectionReqService.GetByEmp(logged);
            return View(data);
        }
        [HttpGet]
        public ActionResult Res() {
            return View();
        }
        [HttpPost]
        public ActionResult Res(CollectionReqDTO col) {
            col.Status = "Open";
            CollectionReqService.Add(col);
            return View();
        }
        public ActionResult Assign(int id) {
            ViewBag.emps = UserService.GetAllEmps();
            ViewBag.id = id;
            return View();
        }
    }
}