using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Test
{
    public class AutomapperData
    {
        public static IEnumerable<object[]> ProductVmToEntity =>
            new List<object[]>
            {
                new object[]{
                    new ProductViewModel()
                    {
                        ProductIDVm = 1,
                        ProductNameVm = "Carlos V",
                        QuantityPerUnitVm = "24",
                        CategoryIDVm = 2,
                        DiscontinuedVm = false,
                        ReorderLevelVm = 2,
                        SupplierIDVm = 1,
                        UnitsInStockVm  = 25,
                        UnitPriceVm = 5,
                        UnitsOnOrderVm = 2
                    },
                    new Product()
                    {
                        ProductID = 1,
                        ProductName = "Carlos V",
                        QuantityPerUnit = "24",
                        CategoryID = 2,
                        Discontinued = false,
                        ReorderLevel = 2,
                        SupplierID = 1,
                        UnitsInStock = 25,
                        UnitPrice = 5,
                        UnitsOnOrder = 2
                    }
                },

                new object[]{
                    new ProductViewModel()
                    {
                        ProductIDVm = 3,
                        ProductNameVm = "Isabel",
                        QuantityPerUnitVm = "24",
                        CategoryIDVm = 2,
                        DiscontinuedVm = false,
                        ReorderLevelVm = 2,
                        SupplierIDVm = 1,
                        UnitsInStockVm  = 25,
                        UnitPriceVm = 5,
                        UnitsOnOrderVm = 2
                    },
                    new Product()
                    {
                        ProductID = 3,
                        ProductName = "Isabel",
                        QuantityPerUnit = "24",
                        CategoryID = 2,
                        Discontinued = false,
                        ReorderLevel = 2,
                        SupplierID = 1,
                        UnitsInStock = 25,
                        UnitPrice = 5,
                        UnitsOnOrder = 2
                    }
                }

            };

        public static IEnumerable<object[]> CategoryVmToEntity =>
           new List<object[]>
           {
                new object[]{
                    new CategoryViewModel()
                    {
                        CategoryIDVm = 1,
                        CategoryNameVm  = "Bevarages",
                        DescriptionVm  = "Está buena",
                        PictureVm  = new byte[]{ 1 }
                    },
                    new Category()
                    {
                        CategoryID = 1,
                        CategoryName = "Bevarages",
                        Description = "Está buena",
                        Picture = new byte[]{ 1 }
                    }
                },

                new object[]{
                    new CategoryViewModel()
                    {
                        CategoryIDVm = 2,
                        CategoryNameVm  = "Cerveza",
                        DescriptionVm  = "Está rica",
                        PictureVm  = new byte[]{ 2 }
                    },
                    new Category()
                    {
                        CategoryID = 2,
                        CategoryName = "Cerveza",
                        Description = "Está rica",
                        Picture = new byte[]{ 2 }
                    }
                }

           };

        public static IEnumerable<object[]> VmToEntity =>
           new List<object[]>
           {
                new object[]{
                    new CategoryViewModel()
                    {
                        CategoryIDVm = 1,
                        CategoryNameVm  = "Bevarages",
                        DescriptionVm  = "Está buena",
                        PictureVm  = new byte[]{ 1 }
                    },
                    new Category()
                    {
                        CategoryID = 1,
                        CategoryName = "Bevarages",
                        Description = "Está buena",
                        Picture = new byte[]{ 1 }
                    }
                },

                new object[]{
                    new ProductViewModel()
                    {
                        ProductIDVm = 3,
                        ProductNameVm = "Isabel",
                        QuantityPerUnitVm = "24",
                        CategoryIDVm = 2,
                        DiscontinuedVm = false,
                        ReorderLevelVm = 2,
                        SupplierIDVm = 1,
                        UnitsInStockVm  = 25,
                        UnitPriceVm = 5,
                        UnitsOnOrderVm = 2
                    },
                    new Product()
                    {
                        ProductID = 3,
                        ProductName = "Isabel",
                        QuantityPerUnit = "24",
                        CategoryID = 2,
                        Discontinued = false,
                        ReorderLevel = 2,
                        SupplierID = 1,
                        UnitsInStock = 25,
                        UnitPrice = 5,
                        UnitsOnOrder = 2
                    }
                }

           };
    }
}
