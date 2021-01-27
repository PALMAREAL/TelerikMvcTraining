using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetByCategory(int categoryID);
        Product GetEntity(int id);
        IEnumerable GetAllProducts();
        IEnumerable GetAllDetailsProducts();
        IEnumerable<FunnelSalesViewModel> GetFunnelSalesData();
        IEnumerable<RegionSalesViewModel> GetRegionSalesData();
        IList<SalesPerformersViewModel> GetSalesPerformers();
        IList<StockDataPointViewModel> BoeingStockData();
        IEnumerable<ProductCategoriesViewModel> GetProductCategoriesData();
        IEnumerable<CategoryViewModel> GetCategoriesData();
    }
}