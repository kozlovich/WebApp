using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.EF.DataPersistance
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        TEntity Add(TEntity entity);
        TEntity Delete(TEntity entity);
        void Edit(TEntity entity);
    }
}
