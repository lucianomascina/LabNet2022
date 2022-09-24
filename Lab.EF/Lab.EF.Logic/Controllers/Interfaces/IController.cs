using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public interface IController<TEntity>
    {
        List<TEntity> GetAll();
        string Add(TEntity entity);
        string Update(TEntity entity);
        string Delete(int id);
        TEntity GetById(int id);
    }
}
