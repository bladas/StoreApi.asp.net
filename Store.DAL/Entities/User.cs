using Microsoft.AspNetCore.Identity;
using Store.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public Guid RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
