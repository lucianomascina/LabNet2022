using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Repositories
{
    public class ProductsLogic : BaseLogic<Products>
    {
        public override void Add(Products entity)
        {
            _context.Products.Add(entity);
            _context.SaveChanges();
        }

        public override void Delete(int id)
        {
            var productToDelete = _context.Products.Find(id);

            _context.Products.Remove(productToDelete);

            _context.SaveChanges();
        }

        public override async Task<List<Products>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public override async Task<Products> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public override void Update(Products entity)
        {
            var productToUpdate = _context.Products.Find(entity.ProductID);

            productToUpdate.ProductName = entity.ProductName;
            productToUpdate.CategoryID = entity.CategoryID;
            productToUpdate.QuantityPerUnit = entity.QuantityPerUnit;
            productToUpdate.UnitsInStock = entity.UnitsInStock;
            productToUpdate.SupplierID = entity.SupplierID;
            productToUpdate.UnitPrice = entity.UnitPrice;

            _context.SaveChanges();
        }
    }
}
