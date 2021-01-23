using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
         Product GetByCategory(int categoryID);
    }
}
