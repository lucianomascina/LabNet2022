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
    public class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public async Task<List<Products>> GetAll()
        {
            return await context.Products.ToListAsync();
        }
        public void Add(Products product)
        {
            context.Products.Add(product);

            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var productToDelete = context.Products.Find(id);

            context.Products.Remove(productToDelete);

            context.SaveChanges();
        }
        public void Update(Products product)
        {
            var productToUpdate = context.Products.Find(product.ProductID);

            productToUpdate.ProductName = product.ProductName;

            context.SaveChanges();

        }
        public async Task<Products> GetById(int id)
        {
            return await context.Products.FindAsync(id);
        }

    }
}
