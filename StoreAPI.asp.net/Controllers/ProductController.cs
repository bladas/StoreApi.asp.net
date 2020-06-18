using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.BLL.Interfaces;
using Store.DAL.EF;
using Store.DAL.Entities;
using StoreAPI.asp.net.ViewModel;

namespace StoreAPI.asp.net.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductController(AppDBContext context,
            IProductService productService, IMapper mapper
          )
        {
            _context = context;
            _mapper = mapper;
            _productService = productService;
            
        }

        [HttpPost("addproduct")]
        public async Task<IActionResult> AddProduct([FromBody]ProductViewModel value)
        {
            if (!ModelState.IsValid) {
                return BadRequest();
            }

            var product = _mapper.Map<ProductViewModel, ProductDTO>(value);
             var result =  await _productService.AddProductAsync(product);

            if (!result.Succeeded) return BadRequest(result.Message);

            return Ok(result.Message);
                                
        }

        [HttpPut("updateproduct/{id}")]
        public IActionResult Update(ProductViewModel model)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == model.Id);
            if (product == null) return BadRequest();

            product.Name = model.Name;
            product.ShortDescription = model.ShortDescription;
            product.Price = model.Price;

            _context.Products.Update(product);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("deleteproduct/{id}")]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null) return BadRequest();


            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok();
        }


        [HttpGet("getproduct/{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            
            if (product == null) return BadRequest();

            return Ok(product);
        }

        [HttpGet("getallproducts")]
        public IActionResult GetAllProducts()
        {
            var product = _context.Products.ToList();
            if (product == null) return BadRequest();

            return Ok(product);
        }

    }
}