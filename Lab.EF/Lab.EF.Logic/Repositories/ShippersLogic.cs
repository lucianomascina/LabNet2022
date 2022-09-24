using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public void Add(Shippers entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shippers> GetAll()
        {

            return context.Shippers.ToList();
        }

        public Shippers GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Shippers entity)
        {
            throw new NotImplementedException();
        }
    }
}
