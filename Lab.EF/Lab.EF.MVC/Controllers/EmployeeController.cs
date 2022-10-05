﻿using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.EF.MVC.Models;
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
        private ILogic<Employees> _employeesLogic = new EmployeesLogic();
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Employees> employees = await _employeesLogic.GetAll();

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

                return View(employeesViews);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}