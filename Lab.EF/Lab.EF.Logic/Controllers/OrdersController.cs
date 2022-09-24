using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class OrdersController : IController<Orders>
    {
        private OrdersLogic _ordersLogic = new OrdersLogic();

        public List<Orders> GetAll()
        {
            List<Orders> ordersList = null;

            try
            {
                ordersList = _ordersLogic.GetAll();
                return ordersList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Add(Orders entity)
        {
            throw new NotImplementedException();
        }
        public string Update(Orders entity)
        {
            throw new NotImplementedException();
        }
        public string Delete(int id)
        {

            throw new NotImplementedException();
        }
        public Orders GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
