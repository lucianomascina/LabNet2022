using Lab.EF.Entities;
using Lab.EF.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class CustomersController : IController<Customers>
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Add(Customers entity)
        {
            throw new NotImplementedException();
        }
        public string Update(Customers entity)
        {
            throw new NotImplementedException();
        }
        public string Delete(int id)
        {

            throw new NotImplementedException();
        }
        public Customers GetById(int id)
        {
            try
            {
                var customer = _customersLogic.GetById(id);

                return (customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customers GetByIdString(string id)
        {
            try
            {
                var customer = _customersLogic.GetByIdString(id);

                if(customer == null)
                    throw new NullReferenceException("no existe customer con ese id");

                return customer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Customers> GetAllByRegionWA()
        {
            List<Customers> customersList = null;

            try
            {
                customersList = _customersLogic.GetAllByRegionWA();
                return customersList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> GetAllNames()
        {
            List<string> customersList = null;

            try
            {
                customersList = _customersLogic.GetAllNames();
                return customersList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Customers> GetTop3RegionWA()
        {
            List<Customers> customersList = null;

            try
            {
                customersList = _customersLogic.GetTop3RegionWA();
                return customersList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CustomersViewModel> GetAllCountOrders()
        {
            List<CustomersViewModel> customersList = null;

            try
            {
                customersList = _customersLogic.GetAllCountOrders();
                return customersList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
