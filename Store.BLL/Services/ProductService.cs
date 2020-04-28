using Microsoft.AspNetCore.Hosting;
using Store.BLL.Infrastructure;
using Store.BLL.Interfaces;
using Store.DAL.Entities;
using Store.DAL.Repositories;
using Store.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Store.BLL.Services
{
    public class ProductService:IProductService
    {
        private IUnitOfWork Database { get; set; }
        private readonly IHostingEnvironment _appEnvironment;

        public ProductService(IUnitOfWork uow,
           IHostingEnvironment hostingEnvironment)
        {
            Database = uow;
            _appEnvironment = hostingEnvironment;
        }
        public async Task<OperationDetails> CreateProduct(ProductDTO productDTO)
        {
            //add base info about evnt
            Product prod = new Product
            {
                Name = productDTO.Name,
                
                ShortDescription = productDTO.ShortDescription,
                Price = productDTO.Price,
            };
            
            
            await Database.SaveAsync();
            return new OperationDetails(true, "Ok", "");
        }
        public async Task<OperationDetails> UpdateProduct(ProductDTO prodDTO)
        {
            var prod = Database.ProductRepository.GetById(prodDTO.Id);
            
            prod.Name = prodDTO.Name;
            prod.ShortDescription = prodDTO.ShortDescription;
            prod.Price = prodDTO.Price;

           

            await Database.SaveAsync();
            return new OperationDetails(true, "Ok", "");
        }
        public IQueryable<Product> GetAllProducts()
        {
            return Database.ProductRepository.GetAll();
        }
        public void DeleteProduct(int event_id)
        {
            Database.ProductRepository.Delete(Database.ProductRepository.GetById(event_id));
            Database.SaveAsync();
        }

    }
}
