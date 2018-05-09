using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore;
using DevOpsDemo.Models;

namespace DevOpsDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //View Test
            return View();
        }

        public ActionResult ShowPageDetails()
        {
            //Changes
            EmployeeBasicModel contextEmployee = new EmployeeBasicModel
                                                 {
                                                     EmployeeName = Context.Item["Name"],
                                                     EmployeeSalary = Context.Item["Salary"]
                                                 };

            return View("~/Views/Home/ShowPageDetails.cshtml", contextEmployee);
        }
    }
}