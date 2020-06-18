using Store.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Entities
{
    public class Category : IEntity<int>
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
