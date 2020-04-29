using Store.BLL.Infrastructure;
using Store.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.Interfaces
{
    public interface IProductService
    {
        Task<OperationDetails> AddProductAsync(ProductDTO car);
        Task UpdateProductAsync(ProductDTO car);
        Task DeleteProductAsync(int Id);
        //Task<ProductDTO> GetProductByIdAsync(int Id);
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
    }
}
