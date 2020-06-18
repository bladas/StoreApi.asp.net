using Microsoft.EntityFrameworkCore;
using Store.DAL.EF;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.Repositories
{
    public class CategoryRepository: BaseRepository<Category,int>,ICategoryRepository
    {
        public CategoryRepository(AppDBContext _context) : base(_context)
        {
            
        }
        public async Task<Category> GetCategoryDetailsByIdAsync(int Id)
        {
            var category = await context.Categories
                .Include(c => c.Products)
                .Where(c => c.Id == Id)
                .FirstOrDefaultAsync();
            return category;
        }
       
      
        public async Task<List<Category>> GetCategoryDetailsAsync()
        {
            var category = await context.Categories
                .Include(c => c.Products)
                .ToListAsync();
            return category;
        }
        public async Task<object> GetCategoryById(int Id)
        {
            return (await _dbSet.FindAsync(Id));
        }
    }
}
