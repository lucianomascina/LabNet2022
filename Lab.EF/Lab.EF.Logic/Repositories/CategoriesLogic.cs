using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic<Categories>
    {
        public CategoriesLogic(NorthwindContext context)
        {
            _context = context;
        }

        public CategoriesLogic()
        {
            
        }

        public override async Task<List<Categories>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }
        public override void Add(Categories category)
        {
            _context.Categories.Add(category);

            _context.SaveChanges();
        }
        public override void Delete(int id)
        {
            var categoryToDelete = _context.Categories.Find(id);

            _context.Categories.Remove(categoryToDelete);

            _context.SaveChanges();
        }
        public override void Update(Categories category)
        {
            var categoryToUpdate = _context.Categories.Find(category.CategoryID);

            categoryToUpdate.CategoryName = category.CategoryName;
            categoryToUpdate.Description = category.Description;
            _context.SaveChanges();

        }
        public override async Task<Categories> GetById(int id)
        {
            return  await _context.Categories.FindAsync(id);
        }
    }
}
