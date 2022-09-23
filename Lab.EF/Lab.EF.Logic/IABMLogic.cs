using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public interface IABMLogic<TEntity> 
    {
        Task<List<TEntity>> GetAll();
        void Add(TEntity entity);
        void Delete(int id);
        void Update(TEntity entity);
        Task<TEntity> GetById(int id);
        
    }
}
