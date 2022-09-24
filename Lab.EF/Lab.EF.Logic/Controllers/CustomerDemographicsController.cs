using System;
using Lab.EF.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    class CustomerDemographicsController : IController<CustomerDemographics>
    {
        private CustomersDemographicsLogic _customerDemographicsLogic = new CustomersDemographicsLogic();
        public List<CustomerDemographics> GetAll()
        {
            List<CustomerDemographics> customerDemographicsList = null;

            try
            {
                customerDemographicsList = _customerDemographicsLogic.GetAll();
                return customerDemographicsList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Add(CustomerDemographics entity)
        {
            throw new NotImplementedException();
        }
        public string Update(CustomerDemographics entity)
        {
            throw new NotImplementedException();
        }
        public string Delete(int id)
        {

            throw new NotImplementedException();
        }
        public CustomerDemographics GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
