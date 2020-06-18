using AutoMapper;
using Store.BLL.DTO;
using Store.BLL.Infrastructure;
using Store.BLL.Interfaces;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace Store.BLL.Services
{
    public class UserService : BaseService, IUserService
    {

        private readonly IConfiguration _configuration;
        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration) : base(unitOfWork, mapper)
        {
            _configuration = configuration;
        }




        public async Task<object> CreateAsync(UserDTO userDto)
        {
            var user = await unitOfWork.UserManager.FindByEmailAsync(userDto.Email);

            if (user == null)
            {
                var userIdentity = mapper.Map<UserDTO, User>(userDto);
                var result = await unitOfWork.UserManager.CreateAsync(userIdentity, userDto.Password);

                if (result.Errors.Count() > 0)
                    return new OperationDetails(false, result.Errors.FirstOrDefault().ToString(), "");

                await unitOfWork.UserManager.AddToRoleAsync(userIdentity, "User");
                await unitOfWork.SaveAsync();

                return BuildToken(userIdentity);
            }
            else
            {
                return "FCK";
            }

        }
        public async Task<object> SignInAsync(UserDTO userDto)
        {

            var user = await unitOfWork.UserManager.FindByEmailAsync(userDto.Email);
            if (user == null)
            {
                return false;
            }
            //var username = user.UserName;
            var email = user.Email;

            var auth = await unitOfWork.SignInManager.PasswordSignInAsync(email, userDto.Password, false, lockoutOnFailure: false);
            if (auth.Succeeded)
            {
                //return "Login successful";
                return BuildToken(user);
            }
            else
            {
                return "Not succeeded (invalid password)";
            }

        }
        public async Task SignOutAsync()
        {
            await unitOfWork.SignInManager.SignOutAsync();
        }

        private UserTokenDTO BuildToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Email),

                new Claim(ClaimTypes.Email, user.Email)
            };


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Expiration time
            var expiration = DateTime.UtcNow.AddDays(1);

            JwtSecurityToken token = new JwtSecurityToken(
               issuer: null,
               audience: null,
               claims: claims,
               expires: expiration,
               signingCredentials: creds);

            return new UserTokenDTO()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token)//,
                //Expiration = expiration
            };
        }
        public async Task<object> GetUserFromAccessToken(string Token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_configuration["JwtSecurityKey"]);

                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };

                SecurityToken securityToken;
                var principle = tokenHandler.ValidateToken(Token, tokenValidationParameters, out securityToken);

                JwtSecurityToken jwtSecurityToken = securityToken as JwtSecurityToken;

                if (jwtSecurityToken != null && jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                {
                    var userEmail = principle.FindFirst(ClaimTypes.Email)?.Value;
                    var res = mapper.Map<User, UserDTO>(await unitOfWork.UserManager.FindByEmailAsync(userEmail));
                    return res;
                }
            }
            catch (Exception)
            {
                return "Exception"; 
            }

            return new UserDTO();
        }
    }
}