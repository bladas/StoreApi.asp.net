using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ProductController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost("addproduct")]
        public IActionResult AddProduct(ProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var product = new Product
            {
                Name = model.Name,
                
                Price = model.Price
            };

            _context.Products.Add(product);
            _context.SaveChanges();

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