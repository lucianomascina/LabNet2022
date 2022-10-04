using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class CustomerView
    {
        [Required(ErrorMessage = "debe ingresar el id")]
        public string CustomerID { get; set; }

        [Required(ErrorMessage = "debe ingresar el nombre de la compañia")]
        public string CompanyName { get; set; }

     
        public string ContactName { get; set; }

       
        public string ContactTitle { get; set; }

     
        public string Address { get; set; }

      
        public string City { get; set; }

      
        public string Region { get; set; }

       
        public string Country { get; set; }

       
        public string Phone { get; set; }

    }
}