using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Services
{
    public class CustomerDemographicService : IService<CustomerDemographics>
    {
        private ILogic<CustomerDemographics> _customerDemographicsLogic = new CustomersDemographicsLogic();

        public void Add(CustomerDemographics entity)
        {
            _customerDemographicsLogic.Add(entity);
        }

        public void Delete(int id)
        {
            _customerDemographicsLogic.Delete(id);
        }

        public async Task<List<CustomerDemographics>> GetAll()
        {
            return await _customerDemographicsLogic.GetAll();
        }

        public async Task<CustomerDemographics> GetById(int id)
        {
            return await _customerDemographicsLogic.GetById(id);
        }

        public void Update(CustomerDemographics entity)
        {
            _customerDemographicsLogic.Update(entity);
        }
    }
}
