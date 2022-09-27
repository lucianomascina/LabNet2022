using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CustomersLogic : BaseLogic<Customers>
    {
        public override List<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }
        public override void Add(Customers customer)
        {
            _context.Customers.Add(customer);

            _context.SaveChanges();
        }
        public override void Delete(int id)
        {
            var customerToDelete = _context.Customers.Find(id);

            _context.Customers.Remove(customerToDelete);

            _context.SaveChanges();
        }
        public override void Update(Customers customer)
        {
            var customerToUpdate = _context.Customers.Find(customer.CustomerID);

          

            _context.SaveChanges();

        }
        public override Customers GetById(int id)
        {
            return  _context.Customers.Find(id);
        }


    }
}
