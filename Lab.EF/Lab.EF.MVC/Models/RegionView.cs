using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class RegionView
    {
        [Display(Name = "Region ID")]
        public int RegionID { get; set; }

        [Required(ErrorMessage = "debe ingresar la descripcion")]
        [StringLength(50)]
        [Display(Name = "Region Description")]
        public string RegionDescription { get; set; }
    }
}