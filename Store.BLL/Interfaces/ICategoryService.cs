using Store.BLL.DTO;
using Store.BLL.Infrastructure;
using Store.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.Interfaces
{
    public interface ICategoryService
    {
        
        Task<OperationDetails> AddCategoryAsync(CategoryDTO category);
        Task UpdateCategoryAsync(CategoryDTO category);
        Task DeleteCategoryAsync(int Id);
        Task<object> GetCategoryByIdAsync(int Id);
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();
    }
}
