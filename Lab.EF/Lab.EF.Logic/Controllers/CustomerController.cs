using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class CustomerController : IController<Customers>
    {
        private CustomersLogic _customersLogic = new CustomersLogic();

      
      

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAll()
        {
            List<Customers> customersList = null;

            try
            {
                customersList = _customersLogic.GetAll();
                return customersList;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Customers GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
