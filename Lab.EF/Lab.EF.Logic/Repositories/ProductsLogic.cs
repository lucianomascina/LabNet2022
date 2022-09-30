using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Repositories
{
    public class ProductsLogic : BaseLogic<Products>
    {
        public override List<Products> GetAll()
        {
            return _context.Products.ToList();
        }
        public override void Add(Products product)
        {
            _context.Products.Add(product);

            _context.SaveChanges();
        }
        public override void Delete(int id)
        {
            var productToDelete = _context.Products.Find(id);

            _context.Products.Remove(productToDelete);

            _context.SaveChanges();
        }
        public override void Update(Products product)
        {
            var productToUpdate = _context.Products.Find(product.ProductID);

           
            _context.SaveChanges();

        }
        public override Products GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public List<Products> GetAllWithoutStock()
        {
            var query = from products in _context.Products
                        where products.UnitsInStock == 0
                        orderby products.ProductName
                        select products;

            return query.ToList();
        }

        public List<Products> GetAllWithStock()
        {
            var query = _context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
            return query;
        }

        public Products GetFirstOrNull()
        {
            var query = _context.Products.FirstOrDefault(p => p.ProductID == 789);

            return query;
        }
    }
}
