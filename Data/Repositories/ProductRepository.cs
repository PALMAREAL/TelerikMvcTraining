using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(TelerikContext dbContext) : base(dbContext)
        {

        }

        public Product GetEntity(int id)
        {
            return Get(m => m.ProductID == id, null, "Product").FirstOrDefault();
        }
    }
}