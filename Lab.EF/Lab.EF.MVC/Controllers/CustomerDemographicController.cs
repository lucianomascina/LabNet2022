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
    public class CustomerDemographicController : Controller
    {
        private IService<CustomerDemographics> _customerDemographicService = new CustomerDemographicService();

        public async Task<ActionResult> Index()
        {
            try
            {
                List<CustomerDemographics> customerDemographics = await _customerDemographicService.GetAll();

                List<CustomerDemographicView> customerDemographicsViews = customerDemographics.Select(c => new CustomerDemographicView
                {
                     CustomerTypeID = c.CustomerTypeID,
                     CustomerDesc = c.CustomerDesc  

                }).ToList();

                return View(customerDemographicsViews);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}