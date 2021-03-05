using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GL.FC.Data.Database
{
    public class Repository<T> : IRepository<T>, IDisposable
        where T : BaseEntity
    {
        readonly DataContext context;
        public bool Disposed { get; }
        public Repository(DataContext context)
        {
            this.context = context;
        }
        public T Add(T item)
        {
            var mySet = context.Set<T>();
            mySet.AddRange(item);
            context.SaveChanges();
            return item;
        }

        public bool Remove(params T[] items)
        {
            return true;
        }

        public bool Remove(long id)
        {
            var result = context.Set<T>().Find((int)id);

            if (context.Entry(result).State == EntityState.Detached)
                context.Set<T>().Attach(result);

            context.Set<T>().Remove(result);
            context.SaveChanges();
            return true;
        }

        public bool Update(params T[] items)
        {
            var mySet = context.Set<T>();

            if (items != null)
            {
                foreach (var entityToUpdate in items)
                {
                    mySet.Attach(entityToUpdate);
                    context.Entry(entityToUpdate).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            return true;
        }


        public virtual IList<T> GetAll(string resolvedPropertyNames)
        {
            List<T> list;

            IQueryable<T> dbQuery = context.Set<T>().AsNoTracking().AsQueryable();


            if (!string.IsNullOrWhiteSpace(resolvedPropertyNames))
            {
                foreach (var includeProperty in resolvedPropertyNames.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    dbQuery = dbQuery.Include(includeProperty);
                }
            }

            list = dbQuery.ToList();

            return list;
        }

        public virtual T GetSingle(long id, params Expression<Func<T, object>>[] navigationProperties)
        {

            // assume Entity base class have an Id property for all items
            //var mySet = context.Set<T>();
            //var entity = mySet.Find(id);
            //return (T)entity;

            IQueryable<T> dbQuery = context.Set<T>().AsQueryable().AsNoTracking();

            //Apply eager loading
            foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                dbQuery = dbQuery.Include<T, object>(navigationProperty);

            return dbQuery.FirstOrDefault(e => (e as BaseEntity).Id == id);

        }

        public virtual T FirstOrDefault(Expression<Func<T, bool>> where, string resolvedPropertyNames)
        {
            T item = null;

            IQueryable<T> dbQuery = context.Set<T>().AsNoTracking().AsQueryable();


            if (!string.IsNullOrWhiteSpace(resolvedPropertyNames))
            {
                foreach (var includeProperty in resolvedPropertyNames.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    dbQuery = dbQuery.Include(includeProperty);
                }
            }


            item = dbQuery
                .FirstOrDefault(where); //Apply where clause

            return item;
        }


        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
