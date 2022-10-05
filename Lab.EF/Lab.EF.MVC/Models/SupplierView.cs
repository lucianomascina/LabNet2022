using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class SupplierView
    {
     
        [Display(Name = "SupplierID")]
        public int SupplierID { get; set; }

        [Required(ErrorMessage = "debe ingresar el nombre de compañia")]
        [StringLength(40)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [StringLength(30)]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [StringLength(30)]
        [Display(Name = "Contact Title")]
        public string ContactTitle { get; set; }

        [StringLength(60)]
        public string Address { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(15)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

    }
}