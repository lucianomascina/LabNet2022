﻿using Lab.EF.Entities;
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
    public class OrderDetailController : Controller
    {
        private IService<Order_Details> _orderDetailsService = new OrderDetailService();
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Order_Details> orderDetails = await _orderDetailsService.GetAll();

                List<OrderDetailView> orderDetailsViews = orderDetails.Select(o => new OrderDetailView
                {
                    OrderID = o.OrderID,
                    ProductID = o.ProductID,
                    Discount = o.Discount,
                    Quantity = o.Quantity,
                    UnitPrice = o.UnitPrice 

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