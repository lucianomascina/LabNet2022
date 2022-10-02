using Lab.EF.Data;
using Lab.EF.Entities;
using Lab.EF.Entities.ViewModels;
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

        public override List<Categories> GetAll()
        {
            return  _context.Categories.ToList();
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
        public override Categories GetById(int id)
        {
            return  _context.Categories.Find(id);
        }
        public List<CategoriesViewModel> GetAllWithProducts()
        {
            var query = from categories in _context.Categories
                        join products in _context.Products
                        on categories.CategoryID equals products.CategoryID
                        select new CategoriesViewModel
                        {
                            CategoryId = categories.CategoryID,
                            CategoryName = categories.CategoryName,
                            ProductId = products.ProductID,
                            ProductName = products.ProductName 
                        };

            return query.ToList();
        }
    }
}
