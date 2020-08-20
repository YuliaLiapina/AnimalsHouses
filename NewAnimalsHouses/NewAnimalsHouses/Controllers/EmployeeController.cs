using BusinessLayer.Managers;
using DAL.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using NewAnimalsHouses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace NewAnimalsHouses.Controllers
{
    public class EmployeeController : Controller
    {
        
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeeRegistration()
        {
            return View();
        }

        public ActionResult EmployeeAuthorization()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> EmployeeRegistration(Employee employee)
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<EmployeeManager>();

            var createUser = await userManager.CreateAsync(new Employee
            {
                LastName = employee.LastName,
                Email = employee.Email,
                UserName = employee.LastName,
                BirthDate = DateTime.Now,
                Language=employee.Language
            });

            return RedirectToAction("Index");
        }


    }
}