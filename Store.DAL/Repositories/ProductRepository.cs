using Store.DAL.EF;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.Repositories
{
    public class ProductRepository: BaseRepository<Product>,IProductRepository
    {
        public ProductRepository(AppDBContext context) : base(context)
        {   
        }
    }
}
