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
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Orders> orders = await _orderService.GetAll();

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

                return View(ordersViews);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}