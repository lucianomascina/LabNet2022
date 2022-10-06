using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class CategoryView
    {
        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "debe ingresar nombre de categoria")]
        [StringLength(15)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        //public byte[] Picture { get; set; }
    }
}