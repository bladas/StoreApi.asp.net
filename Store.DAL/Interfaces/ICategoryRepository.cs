using Store.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.Interfaces
{
    public interface ICategoryRepository:IBaseRepository<Category,int>
    {
         Task<Category> GetCategoryDetailsByIdAsync(int Id);
         Task<List<Category>> GetCategoryDetailsAsync();
         Task<object> GetCategoryById(int Id);
    }
}
