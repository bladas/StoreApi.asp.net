using AutoMapper;
using Store.BLL.DTO;
using Store.BLL.Infrastructure;
using Store.BLL.Interfaces;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BLL.Services
{
    public class UserService : BaseService, IUserService 
    {
        public UserService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }




        public async Task<OperationDetails> CreateAsync(UserDTO userDto)
        {
            var user = await unitOfWork.UserManager.FindByEmailAsync(userDto.Email);

            if (user == null)
            {
                var userIdentity = mapper.Map<UserDTO,User>(userDto);
                var result = await unitOfWork.UserManager.CreateAsync(userIdentity, userDto.Password);

                if (result.Errors.Count() > 0)
                    return new OperationDetails(false, result.Errors.FirstOrDefault().ToString(), "");

                await unitOfWork.UserManager.AddToRoleAsync(userIdentity, "User");
                await unitOfWork.SaveAsync();

                return new OperationDetails(true, "Congratulations! Your account has been created.", "");
            }
            else
            {
                return new OperationDetails(false, "User with this login already exists", "Email");
            }

        }
        public async Task<bool> SignInAsync(UserDTO userDto)
        {

            var user = await unitOfWork.UserManager.FindByEmailAsync(userDto.Email);
            if (user == null)
            {
                return false;
            }
            //var username = user.UserName;
            var email = user.Email;

            var auth = await unitOfWork.SignInManager.PasswordSignInAsync(email, userDto.Password, false, lockoutOnFailure: false);

            return auth.Succeeded;
        }
        public async Task SignOutAsync()
        {
            await unitOfWork.SignInManager.SignOutAsync();
        }
       
    }
}
