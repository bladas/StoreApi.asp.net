using Store.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.Interfaces
{
    public interface IProductRepository:IBaseRepository<Product,int>
    {
         Task<Product> GetProductDetailsByIdAsync(int Id);
         Task<List<Product>> GetProductDetailsAsync();
         //Task<PagedList<Product>> GetAllPagesFilteredAsync(ProductParameters parameters);
         //Task<int> GetCarCountAsync(ProductParameters parameters);
    }
}
