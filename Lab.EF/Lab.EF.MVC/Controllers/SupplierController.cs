using Lab.EF.Entities;
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
    public class SupplierController : Controller
    {
        private ILogic<Suppliers> _suppliersLogic = new SuppliersLogic();
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Suppliers> suppliers = await _suppliersLogic.GetAll();

                List<SupplierView> suppliersViews = suppliers.Select(s => new SupplierView
                {
                     SupplierID = s.SupplierID,
                     Phone = s.Phone,
                     CompanyName = s.CompanyName,
                     Address = s.Address,
                     City = s.City,
                     ContactName = s.ContactName,
                     ContactTitle = s.ContactTitle,
                     Country = s.Country 

                }).ToList();

                return View(suppliersViews);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}