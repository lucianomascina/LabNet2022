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
        public List<CustomerDemographics> GetAll()
        {
            return  _context.CustomerDemographics.ToList();
        }
        public void Add(CustomerDemographics customerDemographic)
        {
            _context.CustomerDemographics.Add(customerDemographic);

            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var customerDemographicToDelete = _context.CustomerDemographics.Find(id);

            _context.CustomerDemographics.Remove(customerDemographicToDelete);

            _context.SaveChanges();
        }
        public void Update(CustomerDemographics customerDemographic)
        {
            var customerDemographicToUpdate = _context.CustomerDemographics.Find(customerDemographic.CustomerTypeID);

            customerDemographicToUpdate.CustomerDesc = customerDemographic.CustomerDesc;

            _context.SaveChanges();

        }
        public CustomerDemographics GetById(int id)
        {
            return  _context.CustomerDemographics.Find(id);
        }
    }
}
