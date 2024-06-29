using OST_inventory_B_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OST_inventory_B_2.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            ViewBag.Message = "";
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account Model)
        {
            if (Model.username == "abc" && Model.password == "12345")
            {
                Session["Username"] = Model.username;
                ViewBag.Message = "Login Successfull";
                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                ViewBag.Message = "Incorrect Username or password";
                return View();
            }
            
        }
    }
}