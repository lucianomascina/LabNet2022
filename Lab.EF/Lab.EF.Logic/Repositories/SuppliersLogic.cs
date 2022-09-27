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

        public override List<Suppliers> GetAll()
        {

            return _context.Suppliers.ToList();
        }

        public override Suppliers GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Suppliers entity)
        {
            throw new NotImplementedException();
        }
    }
}
