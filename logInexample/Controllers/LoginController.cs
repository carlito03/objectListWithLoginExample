using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace logInexample.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            ViewBag.message = @"Authorized users only";


            return View();
        }

        [HttpPost]

        public ActionResult Index(string pass)
        {
            if(pass == "demo")
            {
                Session["LoginID"] = 1;
                ViewBag.message = @"Welcome!";

                Response.Redirect("~/Students");

            }
            else
            {
                ViewBag.message = @"Login Failed";


            }

            return View();

        }

    }
}