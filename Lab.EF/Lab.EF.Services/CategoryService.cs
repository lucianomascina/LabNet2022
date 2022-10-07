using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Services
{
    public class CategoryService : IService<Categories>
    {
        private ILogic<Categories> _categoriesLogic = new CategoriesLogic();

        public void Add(Categories entity)
        {
            _categoriesLogic.Add(entity);
        }

        public void Delete(int id)
        {
            _categoriesLogic.Delete(id);
        }

        public async Task<List<Categories>> GetAll()
        {
            return await _categoriesLogic.GetAll();
        }

        public async Task<Categories> GetById(int id)
        {
            return await _categoriesLogic.GetById(id);
        }

        public void Update(Categories entity)
        {
            _categoriesLogic.Update(entity);
        }
    }
}
