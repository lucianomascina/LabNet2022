using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class OrderDetailsLogic : BaseLogic, IABMLogic<Order_Details>
    {
        public void Add(Order_Details entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order_Details> GetAll()
        {

            return _context.Order_Details.ToList();
        }

        public Order_Details GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order_Details entity)
        {
            throw new NotImplementedException();
        }
    }
}
