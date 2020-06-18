using Store.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Store.DAL.Interfaces
{
    public interface IBaseRepository<T, TId> where T : IEntity<TId>
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetAsync(TId Id);

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(TId id);
        IQueryable<T> FindByConditionAsync(Expression<Func<T, bool>> expression);
    }
}
