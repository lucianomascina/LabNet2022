using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class OrderView
    {
      
        [Display(Name = "Order Id")]
        public int OrderID { get; set; }

        [StringLength(5)]
        [Display(Name = "Customer Id")]
        public string CustomerID { get; set; }

        [Display(Name = "Employee Id")]
        public int? EmployeeID { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Order Date")]
        public DateTime? OrderDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Required Date")]
        public DateTime? RequiredDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Shipped Date")]
        public DateTime? ShippedDate { get; set; }

        [Display(Name = "Ship Via")]
        public int? ShipVia { get; set; }

        public decimal? Freight { get; set; }

        [StringLength(40)]
        [Display(Name = "Ship Name")]
        public string ShipName { get; set; }

        [StringLength(15)]
        [Display(Name = "Ship City")]
        public string ShipCity { get; set; }

        [StringLength(15)]
        [Display(Name = "Ship Country")]
        public string ShipCountry { get; set; }
    }
}