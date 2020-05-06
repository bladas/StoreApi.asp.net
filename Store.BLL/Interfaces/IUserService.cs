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
        Task<OperationDetails> CreateAsync(UserDTO userDto);
        Task<bool> SignInAsync(UserDTO userDto);
        Task SignOutAsync();
    }
}
