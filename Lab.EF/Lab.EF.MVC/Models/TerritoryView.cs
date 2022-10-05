using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class TerritoryView
    {

        [Required(ErrorMessage = "debe ingresar el ID de territorio")]
        [StringLength(20)]
        [Display(Name = "Territory Id")]
        public string TerritoryID { get; set; }

        [Required(ErrorMessage = "debe ingresar la descripcion")]
        [StringLength(50)]
        [Display(Name = "Territory Description")]
        public string TerritoryDescription { get; set; }

        [Display(Name = "Region Id")]
        public int RegionID { get; set; }
    }
}