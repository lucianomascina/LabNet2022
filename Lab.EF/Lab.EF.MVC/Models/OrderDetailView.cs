using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class OrderDetailView
    {
        [Display(Name = "Order Id")]
        public int OrderID { get; set; }

        [Display(Name = "Product Id")]
        public int ProductID { get; set; }

        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }

   
    }
}