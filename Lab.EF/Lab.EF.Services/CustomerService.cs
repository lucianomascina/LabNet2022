using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Services
{
    public class CustomerService : IService<Customers>
    {
        private CustomersLogic _customersLogic = new CustomersLogic();

        public void Add(Customers entity)
        {
            _customersLogic.Add(entity);
        }

        public void Delete(int id)
        {
            _customersLogic.Delete(id);
        }

        public async Task<List<Customers>> GetAll()
        {
            return await _customersLogic.GetAll();
        }

        public async Task<Customers> GetById(int id)
        {
            return await _customersLogic.GetById(id);
        }

        public void Update(Customers entity)
        {
            _customersLogic.Update(entity);
        }

        public async Task<Customers> GetByIdString(string id)
        {
            return await _customersLogic.GetByIdString(id);
        }

        public void DeleteByString(string id)
        {
            _customersLogic.DeleteByString(id);
        }
    }
}
