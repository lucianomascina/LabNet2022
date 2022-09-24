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
            return  context.Categories.ToList();
        }
        public void Add(Categories category)
        {
            context.Categories.Add(category);

            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var categoryToDelete = context.Categories.Find(id);

            context.Categories.Remove(categoryToDelete);

            context.SaveChanges();
        }
        public void Update(Categories category)
        {
            var categoryToUpdate = context.Categories.Find(category.CategoryID);

            categoryToUpdate.CategoryName = category.CategoryName;

            context.SaveChanges();

        }
        public Categories GetById(int id)
        {
            return  context.Categories.Find(id);
        }
    }
}
