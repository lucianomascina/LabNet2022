using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class TerritoriesLogic : BaseLogic, IABMLogic<Territories>
    {
        public void Add(Territories entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Territories> GetAll()
        {

            return _context.Territories.ToList();
        }

        public Territories GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Territories entity)
        {
            throw new NotImplementedException();
        }
    }
}
