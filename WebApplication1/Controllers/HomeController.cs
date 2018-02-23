using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //view test
            return View();
        }

        public ActionResult ShowPageDetails()
        {
            EmployeeBasicModel contextEmployee = new EmployeeBasicModel();
            contextEmployee.EmployeeName = Context.Item["Name"];
            contextEmployee.EmployeeSalary = Context.Item["Salary"];

            return View("~/Views/Home/ShowPageDetails.cshtml", contextEmployee);
        }
    }
}