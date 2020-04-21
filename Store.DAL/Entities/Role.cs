using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Entities
{
    public class Role: BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
