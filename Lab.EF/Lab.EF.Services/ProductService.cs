using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.EF.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Services
{
    public class ProductService : IService<Products>
    {
        private ILogic<Products> _productsLogic = new ProductsLogic();

        public void Add(Products entity)
        {
            _productsLogic.Add(entity);
        }

        public void Delete(int id)
        {
            _productsLogic.Delete(id);
        }

        public async Task<List<Products>> GetAll()
        {
            return await _productsLogic.GetAll();
        }

        public async Task<Products> GetById(int id)
        {
            return await _productsLogic.GetById(id);
        }

        public void Update(Products entity)
        {
            _productsLogic.Update(entity);
        }
    }
}
