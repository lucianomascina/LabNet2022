using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public List<Categories> GetAll()
        {
            return  _context.Categories.ToList();
        }
        public void Add(Categories category)
        {
            _context.Categories.Add(category);

            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var categoryToDelete = _context.Categories.Find(id);

            _context.Categories.Remove(categoryToDelete);

            _context.SaveChanges();
        }
        public void Update(Categories category)
        {
            var categoryToUpdate = _context.Categories.Find(category.CategoryID);

            categoryToUpdate.CategoryName = category.CategoryName;

            _context.SaveChanges();

        }
        public Categories GetById(int id)
        {
            return  _context.Categories.Find(id);
        }
    }
}
