using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class OrdersLogic : BaseLogic, IABMLogic<Orders>
    {
        public void Add(Orders entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetAll()
        {

            return _context.Orders.ToList();
        }

        public Orders GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Orders entity)
        {
            throw new NotImplementedException();
        }
    }
}
