using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class CategoriesController : IController<Categories>
    {
        private CategoriesLogic _categoriesLogic = new CategoriesLogic();

        public List<Categories> GetAll()
        {
            List<Categories> categoriesList = null;

            try
            {
                categoriesList = _categoriesLogic.GetAll();
                return categoriesList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Add(Categories entity)
        {
            throw new NotImplementedException();
        }
        public string Update(Categories entity)
        {
            throw new NotImplementedException();
        }
        public string Delete(int id)
        {

            throw new NotImplementedException();
        }
        public Categories GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
