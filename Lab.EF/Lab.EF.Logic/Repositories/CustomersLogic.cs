using Lab.EF.Entities;
using Lab.EF.Logic.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CustomersLogic : BaseLogic<Customers>,ICustomersLogic 
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

        public Customers GetByIdString(string id)
        {
            return _context.Customers.Find(id);
        }

        public List<Customers> GetAllByRegionWA()
        {
            var query = from customers in _context.Customers
                        where customers.Region == "WA"
                        select customers;

            return query.ToList();
        }

        public List<string> GetAllNames()
        {
            var query = from customers in _context.Customers
                        orderby customers.ContactName
                        select customers.ContactName;

            return query.ToList();
        }

        public List<Customers> GetTop3RegionWA()
        {
            var query = _context.Customers.Where(c => c.Region == "WA").Take(3).ToList();

            return query;
        }
    }
}
