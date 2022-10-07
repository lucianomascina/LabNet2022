using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.EF.Logic.Repositories;
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
    public class RegionController : Controller
    {
        private IService<Region> _regionService = new RegionService();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetAll()
        {
            List<Region> regions = await _regionService.GetAll();

            var regionsViews = regions.Select(r => new RegionView
            {
                 RegionID = r.RegionID,
                 RegionDescription = r.RegionDescription,

            }).ToList();

            return Json(regionsViews, JsonRequestBehavior.AllowGet);
        }

    }
}