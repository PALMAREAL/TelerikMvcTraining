using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

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


        public IEnumerable GetAllProducts()
        {
            var result = Enumerable.Range(0, 50).Select(i => new ProductViewModel
            {
                ProductID = i,
                SupplierID = i + 1,
                ProductName = "SamsungTablet" + "  A." + (i * 2),
                UnitPrice = i + 25,
                Discontinued = false,
                CategoryID = i + 2,
                QuantityPerUnit = (i + 10).ToString(),
                UnitsInStock = (uint?)(i + 3),
                UnitsOnOrder = (uint?)(i + 4),
                ReorderLevel = (uint?)(i + 20)
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
                    CategoryID = 1,
                    CategoryName = "Tablet"
                },

                Country = new CountryViewModel()
                {
                    CountryID =  2,
                    CountryNameShort = "br",
                    CountryNameLong = "Brazil"
                },
                TargetSales = i * 2,
                TotalSales = i * 100
            });

            return result;
        }

        public static IEnumerable<ProductCategoriesViewModel> GetProductCategoriesData()
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

        public static IEnumerable<FunnelSalesViewModel> GetFunnelSalesData()
        {
            return new FunnelSalesViewModel[] {
                new FunnelSalesViewModel("Impressions", 35319300),
                new FunnelSalesViewModel("Listed Properties", 15319300),
                new FunnelSalesViewModel("Properties Shown", 12319300),
                new FunnelSalesViewModel("Total Sales", 8319300)
            };
        }

        public static IEnumerable<RegionSalesViewModel> GetRegionSalesData()
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
    }
}