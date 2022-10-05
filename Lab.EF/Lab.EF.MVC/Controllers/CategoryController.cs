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
    public class CategoryController : Controller
    {
        private ILogic<Categories> _categoriesLogic = new CategoriesLogic();
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Categories> categories = await _categoriesLogic.GetAll();

                List<CategoryView> categoriesViews = categories.Select(c => new CategoryView
                {
                     CategoryID = c.CategoryID,
                     CategoryName = c.CategoryName,
                     Description = c.Description,
                     Picture = c.Picture 

                }).ToList();

                return View(categoriesViews);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}