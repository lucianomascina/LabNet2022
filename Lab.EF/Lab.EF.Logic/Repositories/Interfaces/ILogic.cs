using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public interface ILogic<TEntity> 
    {
        List<TEntity> GetAll();
        void Add(TEntity entity);
        void Delete(int id);
        void Update(TEntity entity);
        TEntity GetById(int id);
        

    }
}
