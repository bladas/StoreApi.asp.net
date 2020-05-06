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
using AutoMapper;

namespace Store.BLL.Services
{
    public class ProductService: IProductService
    {
        IUnitOfWork Database;
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork uow, IMapper mapper)
        {
            Database = uow;
            _mapper = mapper;

        }
        public async Task<OperationDetails> AddProductAsync(ProductDTO productDTO)
        {
            var product = _mapper.Map<ProductDTO, Product>(productDTO);
            try { 
                await Database.ProductRepository.AddAsync(product); 
            }
            catch (Exception ex) {
                return new OperationDetails(false,ex.Message,"Error");
            }

            return new OperationDetails(true, "Prodcut has been added", "");

        }
        public async Task DeleteProductAsync(int Id)
        {
            //await Database.ProductRepository.DeleteAsync(Id);
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            var x = await Database.ProductRepository.GetAllAsync();
            List<ProductDTO> result = _mapper.Map<List<ProductDTO>>(x);//надо проверить
            //List<CarDTO> result = new List<CarDTO>();
            //foreach (var element in x)
            //    result.Add(_mapper.Map<Car, CarDTO>(element));
            return result;
        }
        /*
        public async Task<ProductDTO> GetProductByIdAsync(int Id)
        {
            
            var x = await Database.ProductRepository.GetAsync(1);
            return _mapper.Map<Product, ProductDTO>(x);
            
        }
        */
        public async Task UpdateProductAsync(ProductDTO prd)
        {
            var x = _mapper.Map<ProductDTO, Product>(prd);
            await Database.ProductRepository.UpdateAsync(x);
        }
       

    }
}
