using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Services
{
    public class TerritoryService : IService<Territories>
    {
        private ILogic<Territories> _territoriesLogic = new TerritoriesLogic();

        public void Add(Territories entity)
        {
            _territoriesLogic.Add(entity);
        }

        public void Delete(int id)
        {
            _territoriesLogic.Delete(id);
        }

        public async Task<List<Territories>> GetAll()
        {
            return await _territoriesLogic.GetAll();
        }

        public async Task<Territories> GetById(int id)
        {
            return await _territoriesLogic.GetById(id);
        }

        public void Update(Territories entity)
        {
            _territoriesLogic.Update(entity);
        }
    }
}
