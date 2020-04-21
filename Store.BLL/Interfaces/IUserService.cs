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
    public interface IUserService : IDisposable
    {

        Task<OperationDetails> Create(UserDTO userDto);
        Task<bool> Authenticate(UserDTO userDto);
    }
}
