using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Services
{
    public class SupplierService : IService<Suppliers>
    {
        private ILogic<Suppliers> _suppliersLogic = new SuppliersLogic();

        public void Add(Suppliers entity)
        {
            _suppliersLogic.Add(entity);
        }

        public void Delete(int id)
        {
            _suppliersLogic.Delete(id);
        }

        public async Task<List<Suppliers>> GetAll()
        {
            return await _suppliersLogic.GetAll();
        }

        public async Task<Suppliers> GetById(int id)
        {
            return await _suppliersLogic.GetById(id);
        }

        public void Update(Suppliers entity)
        {
            _suppliersLogic.Update(entity);
        }
    }
}
