using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Repositories
{
    public class RegionsLogic : BaseLogic<Region>
    {
        public override void Add(Region entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async override Task<List<Region>> GetAll()
        {
            return await _context.Region.ToListAsync();
        }

        public override Task<Region> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Region entity)
        {
            throw new NotImplementedException();
        }
    }
}
