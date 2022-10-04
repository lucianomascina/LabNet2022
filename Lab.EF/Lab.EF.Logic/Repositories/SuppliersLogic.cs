using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class SuppliersLogic : BaseLogic<Suppliers>
    {
        public override void Add(Suppliers entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<List<Suppliers>> GetAll()
        {

            return await _context.Suppliers.ToListAsync();
        }

        public override async Task<Suppliers> GetById(int id)
        {
            return await _context.Suppliers.FindAsync(id);
        }

        public override void Update(Suppliers entity)
        {
            throw new NotImplementedException();
        }
    }
}
