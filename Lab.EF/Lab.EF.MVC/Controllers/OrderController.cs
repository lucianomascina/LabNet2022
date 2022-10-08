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
    public class OrderController : Controller
    {
        private IService<Orders> _orderService = new OrderService();
        public string draw = "";
        public string start = "";
        public string length = "";
        public int pageSize, skip, recordsTotal;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> GetAll()
        {
            List<Orders> orders = await _orderService.GetAll();

            var draw = Request.Form.GetValues("draw").FirstOrDefault();
            var start = Request.Form.GetValues("start").FirstOrDefault();
            var length = Request.Form.GetValues("length").FirstOrDefault();
;

            pageSize = length != null ? Convert.ToInt32(length) : 0;
            skip = start != null ? Convert.ToInt32(start) : 0;
            recordsTotal = 0;

            List<OrderView> ordersViews = orders.Select(o => new OrderView
            {
                      OrderID = o.OrderID,
                      CustomerID = o.CustomerID,
                      EmployeeID = o.EmployeeID,
                      Freight = o.Freight,
                      OrderDate = o.OrderDate,
                      RequiredDate = o.RequiredDate,
                      ShipCity = o.ShipCity,
                      ShipCountry = o.ShipCountry,
                      ShipName = o.ShipName,
                      ShippedDate = o.ShippedDate,
                      ShipVia = o.ShipVia 

            }).ToList();

            recordsTotal = ordersViews.Count();
            ordersViews = ordersViews.Skip(skip).Take(pageSize).ToList();

            return Json(new {draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal,
                            data = ordersViews});
            
        }
    }
}