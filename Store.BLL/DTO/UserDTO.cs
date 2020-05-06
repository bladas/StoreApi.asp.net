using Store.DAL.Entities;
using Store.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.BLL.DTO
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public string PhoneNumber { get; set; }
        public string Role { get; set; }


    }
}
