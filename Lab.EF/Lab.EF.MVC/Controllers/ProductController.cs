using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.EF.Logic.Repositories;
using Lab.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class ProductController : Controller
    {
        private ILogic<Products> _productsLogic = new ProductsLogic();
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Products> products = await _productsLogic.GetAll();

                List<ProductView> productsViews = products.Select(p => new ProductView
                {
                     ProductID = p.ProductID,
                     CategoryID = p.CategoryID,
                     ProductName = p.ProductName,
                     QuantityPerUnit = p.QuantityPerUnit,
                     SupplierID = p.SupplierID,
                     UnitPrice = p.UnitPrice,
                     UnitsInStock = p.UnitsInStock 

                }).ToList();

                return View(productsViews);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}