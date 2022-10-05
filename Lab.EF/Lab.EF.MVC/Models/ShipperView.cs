using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class ShipperView
    {
        [Display(Name = "Shipper Id")]
        public int ShipperID { get; set; }

        [Required(ErrorMessage = "debe ingresar el nombre de compañia")]
        [StringLength(40)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }
    }
}