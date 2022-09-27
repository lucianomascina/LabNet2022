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
        public override List<CustomerDemographics> GetAll()
        {
            return  _context.CustomerDemographics.ToList();
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
        public override CustomerDemographics GetById(int id)
        {
            return  _context.CustomerDemographics.Find(id);
        }
    }
}
