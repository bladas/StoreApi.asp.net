using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Store.BLL.DTO;
using Store.BLL.Infrastructure;
using Store.BLL.Interfaces;
using Store.DAL.Entities;
using StoreAPI.asp.net.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Store.DAL.EF;

namespace StoreAPI.asp.net.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        //private readonly SignInManager<User> AuthenticationManager;
        public AccountController(AppDBContext context, IUserService userService, IMapper mapper)
        {
            _context = context;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public async Task<ActionResult> Register(RegisterViewModel value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = _mapper.Map<RegisterViewModel, UserDTO>(value);
            var result = await _userService.CreateAsync(user);

            if (result.Succeeded)
            {
                return Ok();
            }
            else
                ModelState.AddModelError(result.Property, result.Message);

            return BadRequest(ModelState);
        }
        [HttpGet("getallusers")]
        public IActionResult GetAllProducts()
        {
            var user = _context.Users.ToList();
            if (user == null) return BadRequest();

            return Ok(user);
        }
    }
}