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
    public class ProductRepository: BaseRepository<Product,int>,IProductRepository
    {
        public ProductRepository(AppDBContext context) : base(context)
        {
            
        }
        public async Task<Product> GetProductDetailsByIdAsync(int Id)
        {
            var product = await context.Products

                .Include(c => c.Category)
                .Where(c => c.Id == Id)
                .FirstOrDefaultAsync();
            return product;
        }
        public async Task<List<Product>> GetProductDetailsAsync()
        {
            var products = await context.Products
                .Include(c => c.Category)
                .ToListAsync();
            return products;
        }
    }
}
