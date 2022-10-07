using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.EF.MVC.Models;
using Lab.EF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private IService<Employees> _employeesService = new EmployeeService();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetAll()
        {
            List<Employees> employees = await _employeesService.GetAll();

            List<EmployeeView> employeesViews = employees.Select(e => new EmployeeView
            {
                EmployeeID = e.EmployeeID,
                BirthDate = e.BirthDate,
                City = e.City,
                FirstName = e.FirstName,
                HireDate = e.HireDate,
                HomePhone = e.HomePhone,
                LastName = e.LastName,
                Region = e.Region,
                ReportsTo = e.ReportsTo,
                Title = e.Title

            }).ToList();

            return Json(employeesViews, JsonRequestBehavior.AllowGet);
        }
      
        
    }
}