using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Data.Repositories
{
    public class ProductRepository : Repository<Product> , IProductRepository
    {

        public ProductRepository(NorthwindDbContext dbContext) : base(dbContext)
        {
        }

        public Product GetByCategory(int categoryID)
        {
            throw new NotImplementedException();
        }

        public Product GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetAllDetailsProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FunnelSalesViewModel> GetFunnelSalesData()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegionSalesViewModel> GetRegionSalesData()
        {
            throw new NotImplementedException();
        }

        public IList<SalesPerformersViewModel> GetSalesPerformers()
        {
            throw new NotImplementedException();
        }

        public IList<StockDataPointViewModel> BoeingStockData()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCategoriesViewModel> GetProductCategoriesData()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryViewModel> GetCategoriesData()
        {
            throw new NotImplementedException();
        }
    }
}