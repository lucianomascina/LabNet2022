using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class OrderDetailsLogic : BaseLogic<Order_Details>
    {
        public override void Add(Order_Details entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Order_Details> GetAll()
        {

            return _context.Order_Details.ToList();
        }

        public override Order_Details GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Order_Details entity)
        {
            throw new NotImplementedException();
        }
    }
}
