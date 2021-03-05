using GL.FC.Shared;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GL.FC.Services
{
    public interface IBaseServices<T> : IDisposable
        where T : ModelBase
    {
        T Add(T item);
        IList<T> GetAll(string resolvedPropertyNames);
        T GetById(long Id, string resolvedPropertyNames);
        bool Remove(long id);
        bool Update(params T[] items);
    }
}
