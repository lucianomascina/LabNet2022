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
        public async Task<List<Customers>> GetAll()
        {
            return await context.Customers.ToListAsync();
        }
        public void Add(Customers customer)
        {
            context.Customers.Add(customer);

            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var customerToDelete = context.Customers.Find(id);

            context.Customers.Remove(customerToDelete);

            context.SaveChanges();
        }
        public void Update(Customers customer)
        {
            var customerToUpdate = context.Customers.Find(customer.CustomerID);

            customerToUpdate.ContactName = customerToUpdate.ContactName;

            context.SaveChanges();

        }
        public async Task<Customers> GetById(int id)
        {
            return await context.Customers.FindAsync(id);
        }


    }
}
