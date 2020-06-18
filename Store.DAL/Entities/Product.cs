using Store.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Entities
{
    public class Product : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string ImagePath { get; set; }

        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
       
    }
}
