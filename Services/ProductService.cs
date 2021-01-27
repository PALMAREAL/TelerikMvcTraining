using System.Collections;
using System.Collections.Generic;
using TelerikMvcTraining.Data.Repositories;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Services
{
    public class ProductService : ServiceBase, IProductService
    {
        public ProductService(IProductRepository productRepository) : base(productRepository) { }

        public void Insert(Product product)
        {
            ProductRepository.Insert(product);
        }

        public void Update(Product product)
        {
            ProductRepository.Update(product);
        }

        public void Delete(int id)
        {
            ProductRepository.Delete(id);
        }

        public void Delete(Product product)
        {
            ProductRepository.Delete(product);
        }

        public Product GetEntity(int id)
        {
            return ProductRepository.GetEntity(id);
        }

        public Product GetByCategory(int categoryID)
        {
            return ProductRepository.GetByCategory(categoryID);
        }

        public IList<StockDataPointViewModel> BoeingStockData()
        {
            return ProductRepository.BoeingStockData();
        }

        public IEnumerable GetAllDetailsProducts()
        {
            return ProductRepository.GetAllDetailsProducts();
        }

        public IEnumerable GetAllProducts()
        {
            return ProductRepository.GetAllProducts();
        }

        public IEnumerable<CategoryViewModel> GetCategoriesData()
        {
            return ProductRepository.GetCategoriesData();
        }

        public IEnumerable<FunnelSalesViewModel> GetFunnelSalesData()
        {
            return ProductRepository.GetFunnelSalesData();
        }

        public IEnumerable<ProductCategoriesViewModel> GetProductCategoriesData()
        {
            return ProductRepository.GetProductCategoriesData();
        }

        public IEnumerable<RegionSalesViewModel> GetRegionSalesData()
        {
            return ProductRepository.GetRegionSalesData();
        }

        public IList<SalesPerformersViewModel> GetSalesPerformers()
        {
            return ProductRepository.GetSalesPerformers();
        }
    }
}