using Lab.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public abstract class BaseLogic<T> : ILogic<T>
    {
        protected NorthwindContext _context;
        public BaseLogic()
        {
            _context = new NorthwindContext();
        }

        public abstract void Add(T entity);
        public abstract void Delete(int id);
        public abstract Task<List<T>> GetAll();
        public abstract Task<T> GetById(int id);
        public abstract void Update(T entity);
  
    }
}
