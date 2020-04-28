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
        Task<OperationDetails> CreateProduct(ProductDTO productDTO);
        Task<OperationDetails> UpdateProduct(ProductDTO productDTO);

       

        IQueryable<Product> GetAllProducts();
    
      


 

        void DeleteProduct(int product_id);
     
    }
}
