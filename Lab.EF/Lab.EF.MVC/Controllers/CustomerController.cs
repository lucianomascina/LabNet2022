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
    public class CustomerController : Controller
    {
        private CustomersLogic _customersLogic = new CustomersLogic();
       
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Customers> customers = await _customersLogic.GetAll();

                List<CustomerView> customersViews = customers.Select(c => new CustomerView
                {
                    CustomerID = c.CustomerID,
                    Address = c.Address,
                    Phone = c.Phone,
                    City = c.City,
                    CompanyName = c.CompanyName,
                    ContactName = c.ContactName,
                    ContactTitle = c.ContactTitle,
                    Country = c.Country,
                    Region = c.Region

                }).ToList();

                return View(customersViews);
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
           
        }

        public ActionResult Create()
        {
           
            return View();
        }


        [HttpPost]
        public ActionResult Create(CustomerView customerView)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Customers customer = new Customers
                    {
                        CustomerID = customerView.CustomerID,
                        Address = customerView.Address,
                        Phone = customerView.Phone,
                        City = customerView.City,
                        CompanyName = customerView.CompanyName,
                        ContactName = customerView.ContactName,
                        ContactTitle = customerView.ContactTitle,
                        Country = customerView.Country,
                        Region = customerView.Region
                    };

                    _customersLogic.Add(customer);

                    return RedirectToAction("Index");
                }
                return View();

            }
            catch(Exception ex)
            {
                return RedirectToAction("Index","Error");
            }

        }

        //[HttpDelete]
        public ActionResult Delete(string id)
        {
            try
            {
                _customersLogic.DeleteByString(id);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Edit()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Edit(CustomerView customerView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Customers customer = new Customers
                    {
                        CustomerID = customerView.CustomerID,
                        Address = customerView.Address,
                        Phone = customerView.Phone,
                        City = customerView.City,
                        CompanyName = customerView.CompanyName,
                        ContactName = customerView.ContactName,
                        ContactTitle = customerView.ContactTitle,
                        Country = customerView.Country,
                        Region = customerView.Region
                    };

                    _customersLogic.Update(customer);

                    return RedirectToAction("Index");
                }
                return View();

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}