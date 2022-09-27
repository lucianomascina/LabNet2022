using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class CategoriesController : IController<Categories>
    {
        private ILogic<Categories> _categoriesLogic = new CategoriesLogic();

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
            string message = string.Empty;

            try
            {
                _categoriesLogic.Add(entity);

                message = "categoria agregada correctamente";

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return message;
        }
        public string Update(Categories entity)
        {
            throw new NotImplementedException();
        }
        public string Delete(int id)
        {
            string message = string.Empty;

            try
            {
                _categoriesLogic.Delete(id);

                message = "categoria borrada correctamente";

            }
            catch (DbUpdateException ex)
            {
                message = "no es posible eliminar la categoria, ya que se encuentra asociada a otra entidad";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return message;
        }
        public Categories GetById(int id)
        {
            try
            {
                var category = _categoriesLogic.GetById(id);

                return (category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
