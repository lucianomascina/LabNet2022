using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.EF.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Services
{
    public class RegionService : IService<Region>
    {
        private ILogic<Region> _regionsLogic = new RegionsLogic();

        public void Add(Region entity)
        {
            _regionsLogic.Add(entity);
        }

        public void Delete(int id)
        {
            _regionsLogic.Delete(id);
        }

        public async Task<List<Region>> GetAll()
        {
            return await _regionsLogic.GetAll();
        }

        public async Task<Region> GetById(int id)
        {
            return await _regionsLogic.GetById(id);
        }

        public void Update(Region entity)
        {
            _regionsLogic.Update(entity);
        }
    }
}
