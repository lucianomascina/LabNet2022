using Lab.EF.Entities;
using Lab.EF.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class ProductsController : IController<Products>
    {
        private ProductsLogic _productsLogic = new ProductsLogic();

        public string Add(Products entity)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            throw new NotImplementedException();
        }

        public Products GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string Update(Products entity)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAllWithoutStock()
        {
            List<Products> productsList = null;

            try
            {
                productsList = _productsLogic.GetAllWithoutStock();
                return productsList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
