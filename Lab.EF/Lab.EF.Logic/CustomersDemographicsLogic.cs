using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CustomersDemographicsLogic : BaseLogic, IABMLogic<CustomerDemographics>
    {
        public async Task<List<CustomerDemographics>> GetAll()
        {
            return await context.CustomerDemographics.ToListAsync();
        }
        public void Add(CustomerDemographics customerDemographic)
        {
            context.CustomerDemographics.Add(customerDemographic);

            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var customerDemographicToDelete = context.CustomerDemographics.Find(id);

            context.CustomerDemographics.Remove(customerDemographicToDelete);

            context.SaveChanges();
        }
        public void Update(CustomerDemographics customerDemographic)
        {
            var customerDemographicToUpdate = context.CustomerDemographics.Find(customerDemographic.CustomerTypeID);

            customerDemographicToUpdate.CustomerDesc = customerDemographic.CustomerDesc;

            context.SaveChanges();

        }
        public async Task<CustomerDemographics> GetById(int id)
        {
            return await context.CustomerDemographics.FindAsync(id);
        }
    }
}
