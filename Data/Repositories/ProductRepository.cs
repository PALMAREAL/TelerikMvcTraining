using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        public ProductRepository(NorthwindDbContext dbContext) : base(dbContext)
        {
        }

        public Product GetByCategory(int categoryID)
        {
            // Get(Definir la expresíón regular)
            throw new NotImplementedException();
        }
    }
}