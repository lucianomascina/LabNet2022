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
    public class OrderDetailController : Controller
    {
        private ILogic<Order_Details> _orderDetailsLogic = new OrderDetailsLogic();
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Order_Details> orderDetails = await _orderDetailsLogic.GetAll();

                List<OrderDetailView> orderDetailsViews = orderDetails.Select(c => new OrderDetailView
                {
                       

                }).ToList();

                return View(orderDetailsViews);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}