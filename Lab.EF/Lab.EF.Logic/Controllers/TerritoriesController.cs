using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class TerritoriesController : IController<Territories>
    {
        private ILogic<Territories> _territoriesLogic = new TerritoriesLogic();

        public List<Territories> GetAll()
        {
            List<Territories> territoriesList = null;

            try
            {
                territoriesList = _territoriesLogic.GetAll();
                return territoriesList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Add(Territories entity)
        {
            throw new NotImplementedException();
        }
        public string Update(Territories entity)
        {
            throw new NotImplementedException();
        }
        public string Delete(int id)
        {

            throw new NotImplementedException();
        }
        public Territories GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
