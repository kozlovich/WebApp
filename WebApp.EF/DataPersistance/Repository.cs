using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.EF.DataPersistance
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        protected DatabaseContext context;
        protected IDbSet<TEntity> dbSet;

        public Repository(DatabaseContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return dbSet.AsEnumerable();
        }

        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            IEnumerable<TEntity> query = dbSet.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual TEntity Add(TEntity entity)
        {
            return dbSet.Add(entity);
        }

        public virtual TEntity Delete(TEntity entity)
        {
            return dbSet.Remove(entity);
        }

        public virtual void Edit(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
