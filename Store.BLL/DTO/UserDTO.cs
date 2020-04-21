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
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public User GetUser { get; set; }
        public bool IsDeleted { get; set; } = false;
     
        public string Phone { get; set; }
        public string Role { get; set; }

    }
}
