using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CustomersDemographicsLogic : BaseLogic<CustomerDemographics>
    {
        public override async Task<List<CustomerDemographics>> GetAll()
        {
            return await _context.CustomerDemographics.ToListAsync();
        }
        public override void Add(CustomerDemographics customerDemographic)
        {
            _context.CustomerDemographics.Add(customerDemographic);

            _context.SaveChanges();
        }
        public override void Delete(int id)
        {
            var customerDemographicToDelete = _context.CustomerDemographics.Find(id);

            _context.CustomerDemographics.Remove(customerDemographicToDelete);

            _context.SaveChanges();
        }
        public override void Update(CustomerDemographics customerDemographic)
        {
            var customerDemographicToUpdate = _context.CustomerDemographics.Find(customerDemographic.CustomerTypeID);

        

            _context.SaveChanges();

        }
        public override async Task<CustomerDemographics> GetById(int id)
        {
            return await  _context.CustomerDemographics.FindAsync(id);
        }
    }
}
