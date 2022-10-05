using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class CustomerView
    {
        [Required(ErrorMessage = "debe ingresar el costumer id")]
        [StringLength(5)]
        [Display(Name = "Customer Id")]
        public string CustomerID { get; set; }

        [Required(ErrorMessage = "debe ingresar el nombre de la compañia")]
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
        public string Region { get; set; }

        [StringLength(15)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

    }
}