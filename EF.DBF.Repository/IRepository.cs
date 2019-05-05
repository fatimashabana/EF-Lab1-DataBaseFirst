  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DBF.Repository
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(params Object[] id);
        TEntity Add(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);
    }
}
