using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class CustomerDemographicView
    {

        [Required(ErrorMessage = "debe ingresar customer type ID")]
        [StringLength(10)]
        [Display(Name = "Customer Type ID")]
        public string CustomerTypeID { get; set; }

        [Display(Name = "Customer Description")]
        public string CustomerDesc { get; set; }
    }
}