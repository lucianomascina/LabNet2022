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
    }
}
