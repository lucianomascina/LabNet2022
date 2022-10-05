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
    public class RegionController : Controller
    {
        private ILogic<Region> _regionsLogic = new RegionsLogic();
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Region> regions = await _regionsLogic.GetAll();

                List<RegionView> regionsViews = regions.Select(r => new RegionView
                {
                    RegionID = r.RegionID,
                    RegionDescription = r.RegionDescription  

                }).ToList();

                return View(regionsViews);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}