using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using logInexample.Models;
using logInexample.helpers;

using System.IO;

namespace logInexample.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            
            LoginHelper.CheckLogin();
            List<Student> studentList = (List<Student>)Session["studentlist"];
            ViewBag.studentlist = studentList; 
            return View();
        }
    }
}