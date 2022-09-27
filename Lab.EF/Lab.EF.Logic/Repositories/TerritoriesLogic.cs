using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class TerritoriesLogic : BaseLogic<Territories>
    {
        public override void Add(Territories entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Territories> GetAll()
        {

            return _context.Territories.ToList();
        }

        public override Territories GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Territories entity)
        {
            throw new NotImplementedException();
        }
    }
}
