using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class SuppliersLogic : BaseLogic, IABMLogic<Suppliers>
    {
        public void Add(Suppliers entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Suppliers> GetAll()
        {

            return context.Suppliers.ToList();
        }

        public Suppliers GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Suppliers entity)
        {
            throw new NotImplementedException();
        }
    }
}
