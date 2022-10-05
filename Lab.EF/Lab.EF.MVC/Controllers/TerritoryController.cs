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
    public class TerritoryController : Controller
    {
        private ILogic<Territories> _territoriesLogic = new TerritoriesLogic();
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Territories> territories = await _territoriesLogic.GetAll();

                List<TerritoryView> territoriesViews = territories.Select(t => new TerritoryView
                {
                     TerritoryID = t.TerritoryID,
                     RegionID = t.RegionID,
                     TerritoryDescription = t.TerritoryDescription    

                }).ToList();

                return View(territoriesViews);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}