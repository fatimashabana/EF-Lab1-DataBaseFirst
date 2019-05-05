using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DBF.Repository
{
    public class Repository<TEntity,Tcontext> : IRepository<TEntity>
        where TEntity:class
         where Tcontext:DbContext
    {
        Tcontext context;
        DbSet<TEntity> set;
        public Repository(Tcontext context)
        {
            this.context = context;
            set = context.Set<TEntity>();
        }
        public TEntity Add(TEntity entity)
        {
            set.Add(entity);
            return context.SaveChanges() > 0 ? entity : null;
        }

        public IQueryable<TEntity> GetAll()
        {
            return set;
        }

        public TEntity GetById(params object[] id)
        {
            return set.Find(id);
        }

        public bool Remove(TEntity entity)
        {
            set.Remove(entity);
            return context.SaveChanges() > 0;
        }

        public bool Update(TEntity entity)
        {
            set.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }
    }
}
