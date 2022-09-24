using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class OrderDetailsController : IController<Order_Details>
    {
        private OrderDetailsLogic _orderDetailsLogic = new OrderDetailsLogic();

        public List<Order_Details> GetAll()
        {
            List<Order_Details> orderDetailsList = null;

            try
            {
                orderDetailsList = _orderDetailsLogic.GetAll();
                return orderDetailsList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Add(Order_Details entity)
        {
            throw new NotImplementedException();
        }
        public string Update(Order_Details entity)
        {
            throw new NotImplementedException();
        }
        public string Delete(int id)
        {

            throw new NotImplementedException();
        }
        public Order_Details GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
