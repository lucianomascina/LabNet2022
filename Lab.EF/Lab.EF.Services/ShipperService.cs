using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Services
{
    public class ShipperService : IService<Shippers>
    {
        private ILogic<Shippers> _shippersLogic = new ShippersLogic();

        public void Add(Shippers entity)
        {
            _shippersLogic.Add(entity);
        }

        public void Delete(int id)
        {
            _shippersLogic.Delete(id);
        }

        public async Task<List<Shippers>> GetAll()
        {
            return await _shippersLogic.GetAll();
        }

        public async Task<Shippers> GetById(int id)
        {
            return await _shippersLogic.GetById(id);
        }

        public void Update(Shippers entity)
        {
            _shippersLogic.Update(entity);
        }
    }
}
