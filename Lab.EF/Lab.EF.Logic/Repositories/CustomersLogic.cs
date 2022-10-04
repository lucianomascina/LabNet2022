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
        public override async Task<List<Customers>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }
        public override void Add(Customers customer)
        {
            _context.Customers.Add(customer);

            _context.SaveChanges();
        }
        public void DeleteByString(string id)
        {
            var customerToDelete = _context.Customers.Find(id);

            _context.Customers.Remove(customerToDelete);

            _context.SaveChanges();
        }
        public override void Update(Customers customer)
        {
            var customerToUpdate = _context.Customers.Find(customer.CustomerID);

            customerToUpdate.CompanyName = customer.CompanyName;
            customerToUpdate.ContactName = customer.ContactName;
            customerToUpdate.ContactTitle = customer.ContactTitle;
            customerToUpdate.Address = customer.Address;
            customerToUpdate.City = customer.City;
            customerToUpdate.Region = customer.Region;
            customerToUpdate.Country = customer.Country;
            customerToUpdate.Phone = customer.Phone;

            _context.SaveChanges();

        }
        public async Task<Customers> GetByIdString(string id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<Customers> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
