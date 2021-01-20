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


        internal IEnumerable GetAllProducts()
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

        internal IEnumerable GetAllDetailsProducts()
        {
            var result = Enumerable.Range(0, 50).Select(i => new DetailProductViewModel
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
                ReorderLevel = (uint?)(i + 20),
                TargetSales = i * 2,
                TotalSales = i +3 
            });

            return result;
        }
    }
}