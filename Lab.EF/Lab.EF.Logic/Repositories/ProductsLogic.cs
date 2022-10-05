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
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<List<Products>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public override Task<Products> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Products entity)
        {
            throw new NotImplementedException();
        }
    }
}
