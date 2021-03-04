using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GL.FC.Data.Database
{
    public interface IRepository<TEntity> : IDisposable 
        where TEntity : BaseEntity
    {
        IList<TEntity> GetAll(string resolvedPropertyNames);
        TEntity GetSingle(long id, params Expression<Func<TEntity, object>>[] navigationProperties);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> where, string resolvedPropertyNames);
        TEntity Add(TEntity item);
        bool Update(params TEntity[] items);
        bool Remove(params TEntity[] items);
        bool Remove(long Id);
    }
}
