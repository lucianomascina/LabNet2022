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
    public class ShipperController : Controller
    {
        private IService<Shippers> _shipperService = new ShipperService();

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public  async Task<JsonResult> GetAll()
        {
            List<Shippers> shippers =  await _shipperService.GetAll();

            var shippersViews =  shippers.Select(s => new ShipperView
            {
                ShipperID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone

            }).ToList();

            return Json(shippersViews,JsonRequestBehavior.AllowGet);
        }
        
      
    }
}