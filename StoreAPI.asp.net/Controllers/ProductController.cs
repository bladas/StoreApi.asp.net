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
            IProductService productService,
            IMapper mapper)
        {
            _context = context;
            _productService = productService;
            _mapper = mapper;
            
        }

        [HttpPost("addproduct")]
        public async Task<IActionResult> AddProduct(ProductViewModel model)
        {
            /*
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var product = new Product
            {
                Name = model.Name,
                ShortDescription = model.ShortDescription,
                Price = model.Price
            };

            await _context.Products.AddAsync(product);
           

            return Ok();
            */
            ProductDTO productDTO = _mapper.Map<ProductViewModel, ProductDTO>(model);
            await _productService.CreateProduct(productDTO);
            return Ok();
           
        }

        [HttpPut("updateproduct")]
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

        [HttpDelete("deleteproduct")]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null) return BadRequest();


            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok();
        }


        [HttpGet("getproduct")]
        public IActionResult GetProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
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