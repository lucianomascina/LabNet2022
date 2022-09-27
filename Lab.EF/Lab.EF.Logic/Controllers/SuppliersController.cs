using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class SuppliersController : IController<Suppliers>
    {
        private ILogic<Suppliers> _suppliersLogic = new SuppliersLogic();

        public List<Suppliers> GetAll()
        {
            List<Suppliers> suppliersList = null;

            try
            {
                suppliersList = _suppliersLogic.GetAll();
                return suppliersList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Add(Suppliers entity)
        {
            throw new NotImplementedException();
        }
        public string Update(Suppliers entity)
        {
            throw new NotImplementedException();
        }
        public string Delete(int id)
        {

            throw new NotImplementedException();
        }
        public Suppliers GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
