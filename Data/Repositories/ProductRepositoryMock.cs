using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Data.Repositories
{
    public class ProductRepositoryMock : Repository<Product>, IProductRepository
    {

        public ProductRepositoryMock(NorthwindDbContext dbContext) : base(dbContext)
        {
        }
        public Product GetByCategory(int categoryID)
        {
            throw new NotImplementedException();
        }

        public Product GetEntity(int id)
        {
            return Get(m => m.ProductID == id, null, "Product").FirstOrDefault();
        }

        public IEnumerable GetAllProducts()
        {
            var result = Enumerable.Range(0, 100).Select(i => new ProductViewModel
            {
                ProductIDVm = i,
                SupplierIDVm = i + 1,
                ProductNameVm = "SamsungTablet" + "  A." + (i * 2),
                UnitPriceVm = i + 25,
                DiscontinuedVm = false,
                CategoryIDVm = i + 2,
                QuantityPerUnitVm = (i + 10).ToString(),
                UnitsInStockVm  = (uint?)(i + 3),
                UnitsOnOrderVm = (uint?)(i + 4),
                ReorderLevelVm = (uint?)(i + 20)
            });

            return result;
        }

        public IEnumerable GetAllDetailsProducts()
        {
            var result = Enumerable.Range(0, 50).Select(i => new DetailProductViewModel
            {
                ProductID = i,
                ProductName = "SamsungTablet" + "  A." + (i * 2),
                UnitPrice = i + 25,
                Discontinued = true,
                CategoryID = i + 2,
                QuantityPerUnit = (i + 10).ToString(),
                UnitsInStock = i + 3,
                UnitsOnOrder = i + 4,
                Category = new CategoryViewModel()
                {
                    CategoryIDVm = 1,
                    CategoryNameVm = "Tablet"
                },

                Country = new CountryViewModel()
                {
                    CountryID = 2,
                    CountryNameShort = "br",
                    CountryNameLong = "Brazil"
                },
                TargetSales = i * 2,
                TotalSales = i * 100
            });

            return result;
        }

        public IEnumerable<FunnelSalesViewModel> GetFunnelSalesData()
        {
            return new FunnelSalesViewModel[] {
                new FunnelSalesViewModel("Impressions", 35319300),
                new FunnelSalesViewModel("Listed Properties", 15319300),
                new FunnelSalesViewModel("Properties Shown", 12319300),
                new FunnelSalesViewModel("Total Sales", 8319300)
            };
        }

        public IEnumerable<RegionSalesViewModel> GetRegionSalesData()
        {
            return new RegionSalesViewModel[] {
                new RegionSalesViewModel("Africa", 17.6),
                new RegionSalesViewModel("Middle East", 9.2),
                new RegionSalesViewModel("North America", 4.6),
                new RegionSalesViewModel("Asia", 30.8),
                new RegionSalesViewModel("Europe", 21.1),
                new RegionSalesViewModel("Latin America", 16.3)
            };
        }

        public IList<SalesPerformersViewModel> GetSalesPerformers()
        {
            return new SalesPerformersViewModel[] {
                new SalesPerformersViewModel("John Smith", 1594000),
                new SalesPerformersViewModel("Annie Johnson", 1860500),
                new SalesPerformersViewModel("Christine Quinn", 1035000),
                new SalesPerformersViewModel("Sophia Williams", 980000),
                new SalesPerformersViewModel("Jacob Martinez", 1780000)
            };
        }

        public IList<StockDataPointViewModel> BoeingStockData()
        {
            return new StockDataPointViewModel[] {
                new StockDataPointViewModel(){ Close = 25, Date = new DateTime(2011,10,10), High = 175, Low = 65, Open = 45, Symbol = "Hello", Volume = 33},
                new StockDataPointViewModel(){ Close = 24, Date = new DateTime(2011,10,10), High = 174, Low = 65, Open = 45, Symbol = "Hello", Volume = 32},
                new StockDataPointViewModel(){ Close = 23, Date = new DateTime(2011,10,10), High = 173, Low = 65, Open = 45, Symbol = "Hello", Volume = 31},
                new StockDataPointViewModel(){ Close = 22, Date = new DateTime(2011,10,10), High = 172, Low = 65, Open = 45, Symbol = "Hello", Volume = 30}
            };
        }

        public IEnumerable<ProductCategoriesViewModel> GetProductCategoriesData()
        {
            return new ProductCategoriesViewModel[] {
                new ProductCategoriesViewModel("2010", 2085200, 3080700, 1485700, 6651600),
                new ProductCategoriesViewModel("2011", 2091800, 3386400, 1525800, 7004000),
                new ProductCategoriesViewModel("2012", 3002100, 2627000, 1095500, 6724600),
                new ProductCategoriesViewModel("2013", 3008000, 4389700, 1907500, 9305200),
                new ProductCategoriesViewModel("2014", 3015000, 3443900, 1570000, 8028900),
                new ProductCategoriesViewModel("2015", 3035000, 2302500, 2117600, 7455100),
                new ProductCategoriesViewModel("2016", 3042000, 2983100, 2329700, 8354800),
                new ProductCategoriesViewModel("2017", 3044400, 3052200, 2756800, 8853400),
                new ProductCategoriesViewModel("2018", 3057800, 2611200, 3220300, 8889300),
                new ProductCategoriesViewModel("2019", 3087800, 2211200, 3020300, 8319300)
            };
        }

        public IEnumerable<CategoryViewModel> GetCategoriesData()
        {
            return new CategoryViewModel[] {
            new CategoryViewModel() { CategoryIDVm = 1, CategoryNameVm = "Beverages", DescriptionVm = "Soft drinks, coffees, teas, beers, and ales" },
            new CategoryViewModel() { CategoryIDVm = 2, CategoryNameVm = "Condiments", DescriptionVm = "Sweet and savory sauces, relishes, spreads, and seasonings" },
            new CategoryViewModel() { CategoryIDVm = 3, CategoryNameVm = "Confections", DescriptionVm = "Desserts, candies, and sweet breads" },
            new CategoryViewModel() { CategoryIDVm = 4, CategoryNameVm = "Dairy Products", DescriptionVm = "Cheeses" },
            new CategoryViewModel() { CategoryIDVm = 5, CategoryNameVm = "Grains/Cereals", DescriptionVm = "Breads, crackers, pasta, and cereal" },
            new CategoryViewModel() { CategoryIDVm = 6, CategoryNameVm = "Meat/Poultry", DescriptionVm = "Prepared meats" },
            new CategoryViewModel() { CategoryIDVm = 7, CategoryNameVm = "Produce", DescriptionVm = "Dried fruit and bean curd" },
            new CategoryViewModel() { CategoryIDVm = 8, CategoryNameVm = "Seafood", DescriptionVm = "Seaweed and fish" }
            };
        }
    }
}




