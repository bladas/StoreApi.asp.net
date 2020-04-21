using Store.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.asp.net.ViewModel
{
    public class ProductViewModel
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string ShortDescription { get; set; }
        [Required]
        public decimal Price { get; set; }
        
        /*
        public string LongDescription { get; set; }
        

        public bool IsFavourite { get; set; }
        public int Available { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        */
    }
}
