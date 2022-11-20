using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroHungerMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserDTO user) {
            var data = UserService.Get(user.Uname);
            if (data != null) {
                if (data.Password.Equals(user.Password)) {
                    Session["logged"] = data.Uname;
                    Session["type"] = data.Type;
                    switch (data.Type) {
                        case "Ngo":
                            return RedirectToAction("Ngo", "Dashboard");
                        case "Res":
                            return RedirectToAction("Res", "Dashboard");
                        case "Emp":
                            return RedirectToAction("Emp", "Dashboard");
                    }
                }
            }
            TempData["msg"] = "Username password invalid";
            return RedirectToAction("Index");
        }
    }
}