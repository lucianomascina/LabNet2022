using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Entities.ViewModels
{
    public class OrdersViewModel
    {
        public int OrderId { get; set; }
        public  DateTime? OrderDate { get; set; }
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string Region { get; set; }

    }
}
