using Store.BLL.DTO;
using Store.BLL.Infrastructure;
using Store.DAL.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.Interfaces
{
    public interface IUserService 
    {
        Task<object> CreateAsync(UserDTO userDto);
        Task<object> SignInAsync(UserDTO userDto);
        Task SignOutAsync();
    }
}
