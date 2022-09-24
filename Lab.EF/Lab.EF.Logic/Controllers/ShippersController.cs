using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class ShippersController : IController<Shippers>
    {
        private ShippersLogic _shippersLogic = new ShippersLogic();

        public List<Shippers> GetAll()
        {
            List<Shippers> shippersList = null;

            try
            {
                shippersList = _shippersLogic.GetAll();
                return shippersList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Add(Shippers entity)
        {
            throw new NotImplementedException();
        }
        public string Update(Shippers entity)
        {
            throw new NotImplementedException();
        }
        public string Delete(int id)
        {

            throw new NotImplementedException();
        }
        public Shippers GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
