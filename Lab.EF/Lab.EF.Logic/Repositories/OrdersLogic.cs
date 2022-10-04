using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class OrdersLogic : BaseLogic<Orders>
    {
        public override void Add(Orders entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<List<Orders>> GetAll()
        {
             
            return await _context.Orders.ToListAsync();
        }

        public override async Task<Orders> GetById(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public override void Update(Orders entity)
        {
            throw new NotImplementedException();
        }
    }
}
