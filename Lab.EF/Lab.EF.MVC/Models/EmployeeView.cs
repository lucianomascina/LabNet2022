using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class EmployeeView
    {
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "debe ingresar el apellido")]
        [StringLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "debe ingresar el nombre")]
        [StringLength(10)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime? HireDate { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        [StringLength(24)]
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [Display(Name = "Reports To")]
        public int? ReportsTo { get; set; }

      
    }
}