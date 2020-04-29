using Store.DAL.Interfaces;
using Store.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Store.DAL.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Store.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly AppDBContext context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(AppDBContext _context)
        {
            context = _context;
            _dbSet = _context.Set<T>();
        }

        
        public async Task AddAsync(T entity)
        {
            _dbSet.Add(entity);
            await context.SaveChangesAsync();          
        }
        public async Task UpdateAsync(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T id)
        {
            T x = await _dbSet.FindAsync(id);
            _dbSet.Remove(x);
            await context.SaveChangesAsync();
        }

        public async Task<T> GetAsync(T Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public IQueryable<T> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
       
    }
}
