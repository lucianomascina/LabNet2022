using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }
        public void Add(Products product)
        {
            context.Products.Add(product);

            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var productoAEliminar = context.Products.Find(id);

            context.Products.Remove(productoAEliminar);

            context.SaveChanges();
        }
        public void Update(Products product)
        {
            var productUpdate = context.Products.Find(product.ProductID);

            productUpdate.ProductName = product.ProductName;

            context.SaveChanges();

        }
    
    }
}
