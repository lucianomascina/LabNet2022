using Lab.EF.Entities;
using Lab.EF.Logic;
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
    public class CategoryController : Controller
    {
        private IService<Categories> _categoryService = new CategoryService();
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Categories> categories = await _categoryService.GetAll();

                List<CategoryView> categoriesViews = categories.Select(c => new CategoryView
                {
                     CategoryID = c.CategoryID,
                     CategoryName = c.CategoryName,
                     Description = c.Description,
                     

                }).ToList();

                return View(categoriesViews);
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
        public ActionResult Create(CategoryView  categoryView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Categories category = new Categories
                    {
                         CategoryID = categoryView.CategoryID,
                         CategoryName = categoryView.CategoryName,
                         Description = categoryView.Description,
                         
                    };

                    _categoryService.Add(category);
                    TempData["message"] = "category created succesfully!";
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
                _categoryService.Delete(id);
                TempData["message"] = "category deleted succesfully!";
                return RedirectToAction("Index");
            }
            catch(DbUpdateException ex)
            {
                return RedirectToAction("DeleteCategory", "Error");
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
                var category = await _categoryService.GetById(id);

                var categoryView = new CategoryView
                {
                     CategoryID = category.CategoryID,
                     CategoryName = category.CategoryName,
                     Description = category.Description,
                    
                };

                return View(categoryView);

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }

        [HttpPost]
        public ActionResult Edit(CategoryView  categoryView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Categories category = new Categories
                    {
                         CategoryID = categoryView.CategoryID,
                         CategoryName = categoryView.CategoryName,
                         Description = categoryView.Description,
                        
                    };

                    _categoryService.Update(category);
                    TempData["message"] = "category edited succesfully!";
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