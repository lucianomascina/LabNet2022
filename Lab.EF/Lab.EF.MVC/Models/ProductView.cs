using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class ProductView
    {
        [Display(Name = "Product Id")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "debe ingresar un nombre")]
        [StringLength(40)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Supplier Id")]
        public int? SupplierID { get; set; }

        [Display(Name = "Category Id")]
        public int? CategoryID { get; set; }

        [StringLength(20)]
        [Display(Name = "Quantity Per Unit")]
        public string QuantityPerUnit { get; set; }

        [Display(Name = "Unit Price")]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "Units In Stock")]
        public short? UnitsInStock { get; set; }


    }
}