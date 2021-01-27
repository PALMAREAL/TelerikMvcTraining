using System.Collections;
using System.Collections.Generic;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Services
{
    public interface IProductService 
    {
        void Insert(Product product);

        void Update(Product product);

        void Delete(int id);

        void Delete(Product product);

        Product GetEntity(int id);

        Product GetByCategory(int categoryID);

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