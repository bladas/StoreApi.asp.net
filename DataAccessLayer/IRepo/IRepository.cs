using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.IRepo
{
    public interface IRepository<T> where T:class
    {
        T Get(Guid id);
        T Insert(T entity);
        T Update(T entity);
        T Delete(T entity);

        IQueryable<T> Get(string includeProperties = "");
    }
}
