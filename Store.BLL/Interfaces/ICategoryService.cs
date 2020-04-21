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
        List<Category> GetAllCategories();
        Task<OperationDetails> AddCategory(string Name);
        Task<OperationDetails> Delete(int id);

    }
}
