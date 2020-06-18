using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.BLL.DTO;
using Store.BLL.Interfaces;

namespace StoreAPI.asp.net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("getallcategories")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _categoryService.GetAllCategoriesAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult>GetbyId(int id)
        {
            try
            {
                return Ok(await _categoryService.GetCategoryByIdAsync(id));
            }
            catch
            {
                return BadRequest();
            }
        }



        
        [HttpPost("addcategory")]
        public async Task<IActionResult> Add([FromBody]CategoryDTO value)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                await _categoryService.AddCategoryAsync(value);
                return  Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        
        [HttpPut("update")]
        public async Task<IActionResult>Update([FromBody]CategoryDTO value)
        {
            
            try
            {
                await _categoryService.UpdateCategoryAsync(value);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _categoryService.DeleteCategoryAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }
    }
   
}