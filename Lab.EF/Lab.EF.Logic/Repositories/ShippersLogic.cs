using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ShippersLogic : BaseLogic<Shippers>
    {
        public override void Add(Shippers entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<List<Shippers>> GetAll()
        {

            return await _context.Shippers.ToListAsync();
        }

        public override async Task<Shippers> GetById(int id)
        {
            return await _context.Shippers.FindAsync(id);
        }

        public override void Update(Shippers entity)
        {
            throw new NotImplementedException();
        }
    }
}
