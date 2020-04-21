using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string NameCategory { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
