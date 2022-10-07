using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Services
{
    public class OrderService : IService<Orders>
    {
        private ILogic<Orders> _ordersLogic = new OrdersLogic();

        public void Add(Orders entity)
        {
            _ordersLogic.Add(entity);
        }

        public void Delete(int id)
        {
            _ordersLogic.Delete(id);
        }

        public async Task<List<Orders>> GetAll()
        {
            return await _ordersLogic.GetAll();
        }

        public async Task<Orders> GetById(int id)
        {
            return await _ordersLogic.GetById(id);
        }

        public void Update(Orders entity)
        {
            _ordersLogic.Update(entity);
        }
    }
}
