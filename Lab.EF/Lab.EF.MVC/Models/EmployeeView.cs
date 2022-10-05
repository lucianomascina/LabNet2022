using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class EmployeeView
    {
     
        public int EmployeeID { get; set; }
     
        public string LastName { get; set; }

    
        public string FirstName { get; set; }

        public string Title { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }
     
        public string City { get; set; }
     
        public string Region { get; set; }

        public string HomePhone { get; set; }

        public int? ReportsTo { get; set; }

      
    }
}