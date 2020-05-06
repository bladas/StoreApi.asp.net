using Microsoft.AspNetCore.Identity;
using Store.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
