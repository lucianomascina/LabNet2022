using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Services
{
    public class OrderDetailService : IService<Order_Details>
    {
        private ILogic<Order_Details> _orderDetailsLogic = new OrderDetailsLogic();

        public void Add(Order_Details entity)
        {
            _orderDetailsLogic.Add(entity);
        }

        public void Delete(int id)
        {
            _orderDetailsLogic.Delete(id);
        }

        public async Task<List<Order_Details>> GetAll()
        {
            return await _orderDetailsLogic.GetAll();
        }

        public async Task<Order_Details> GetById(int id)
        {
            return await _orderDetailsLogic.GetById(id);
        }

        public void Update(Order_Details entity)
        {
            _orderDetailsLogic.Update(entity);
        }
    }
}
