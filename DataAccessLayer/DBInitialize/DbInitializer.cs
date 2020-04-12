using DataAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.DBInitialize
{
    class DbInitializer
    {/*
        public static void Seed(EFDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();

            //Look for any users
            if (dbContext.Users.Any())
            {
                return; // DB has been seeded
            }

            
            Role adminRole = new Role { Name = "Admin" };
            Role userRole = new Role { Name = "User" };
            dbContext.Role.AddRange(new Role[] { adminRole, userRole });

            var users = new User[] {
                 new User{
                     Name ="Admin",
                     PasswordHash = PasswordHasher.GenerateHash("1qaz1qaz"),
                     Email ="admin@gmail.com",
                     EmailConfirmed = true,
                     Phone="+380974293583",
                     Birthday =DateTime.Parse("2000-01-01"),
                     Gender =Gender.Male,
                     Role =adminRole
                 },

                  new User{
                      Name ="UserTest",
                      PasswordHash = PasswordHasher.GenerateHash("1qaz1qaz"),
                      Email ="user@gmail.com",
                      EmailConfirmed = true,
                      Phone="+380970101013",
                      Birthday =DateTime.Parse("2000-01-01"),
                      Gender =Gender.Male,
                      Role =userRole
                  }
            };

            dbContext.Users.AddRange(users);




            dbContext.SaveChanges();
            */
       // }
    }
}

