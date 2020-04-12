using DataAccessLayer.EF;
using DataAccessLayer.Entities;
using DataAccessLayer.IRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repo
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(EFDbContext db) : base(db)
        {

        }
    }
}


