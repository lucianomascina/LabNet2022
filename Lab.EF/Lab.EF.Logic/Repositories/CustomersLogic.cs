using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }
        public void Add(Customers customer)
        {
            _context.Customers.Add(customer);

            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var customerToDelete = _context.Customers.Find(id);

            _context.Customers.Remove(customerToDelete);

            _context.SaveChanges();
        }
        public void Update(Customers customer)
        {
            var customerToUpdate = _context.Customers.Find(customer.CustomerID);

          

            _context.SaveChanges();

        }
        public Customers GetById(int id)
        {
            return  _context.Customers.Find(id);
        }


    }
}
