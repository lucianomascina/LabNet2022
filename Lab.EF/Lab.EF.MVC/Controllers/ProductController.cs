using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.EF.Logic.Repositories;
using Lab.EF.MVC.Models;
using Lab.EF.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class ProductController : Controller
    {
        private IService<Products> _productService = new ProductService();
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Products> products = await _productService.GetAll();

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
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductView productView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Products product = new Products
                    {
                         ProductID = productView.ProductID,
                         ProductName = productView.ProductName,
                         CategoryID = productView.CategoryID,
                         QuantityPerUnit = productView.QuantityPerUnit,
                         UnitsInStock = productView.UnitsInStock,
                         SupplierID = productView.SupplierID,
                         UnitPrice = productView.UnitPrice,

                    };

                    _productService.Add(product);

                    return RedirectToAction("Index");
                }
                return View();

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }

        //[HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                _productService.Delete(id);

                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                return RedirectToAction("DeleteProduct", "Error");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                var product = await _productService.GetById(id);

                var productView = new ProductView
                {
                     ProductID = product.ProductID,
                     CategoryID = product.CategoryID,
                     ProductName = product.ProductName,
                     QuantityPerUnit = product.QuantityPerUnit,
                     SupplierID = product.SupplierID,
                     UnitPrice = product.UnitPrice,
                     UnitsInStock = product.UnitsInStock 

                };

                return View(productView);

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }

        [HttpPost]
        public ActionResult Edit(ProductView productView )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Products product = new Products
                    {
                        ProductID = productView.ProductID,
                        ProductName = productView.ProductName,
                        CategoryID = productView.CategoryID,
                        QuantityPerUnit = productView.QuantityPerUnit,
                        UnitsInStock = productView.UnitsInStock,
                        SupplierID = productView.SupplierID,
                        UnitPrice = productView.UnitPrice,

                    };

                    _productService.Update(product);

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