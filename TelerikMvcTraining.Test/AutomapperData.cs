using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikMvcTraining.Dtos;
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

        public static IEnumerable<object[]> OrderViewModelToEntity =>
            new List<object[]>
            {
                new object[]{
                    new OrderViewModel()
                    {
                        IdOrden = 1,
                        ClienteId = 1080,
                        FechaCompra = new DateTime(2021,02,10),
                        Categoría = new Category()
                        {
                            CategoryID = 1,
                            CategoryName = "Bevarages",
                            Description = "Está buena",
                            Picture = 123456
                        },
                        País = new Country
                        {
                            CountryID = 1,
                            CountryNameLong = "Cuba",
                            CountryNameShort = "Cu"
                        }
                    },
                    new Order()
                    {
                        OrderID = 1,
                        CustomerID = 1080,
                        OrderDate = new DateTime(2021,02,10),
                        Category = new Category()
                        {
                            CategoryID = 1,
                            CategoryName = "Bevarages",
                            Description = "Está buena",
                            Picture = 123456
                        },
                        Country = new Country
                        {
                            CountryID = 1,
                            CountryNameLong = "Cuba",
                            CountryNameShort = "Cu"
                        }
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
                        PictureVm  = 123
                    },
                    new Category()
                    {
                        CategoryID = 1,
                        CategoryName = "Bevarages",
                        Description = "Está buena",
                        Picture = 123
                    }
                },

                new object[]{
                    new CategoryViewModel()
                    {
                        CategoryIDVm = 2,
                        CategoryNameVm  = "Cerveza",
                        DescriptionVm  = "Está rica",
                        PictureVm  = 456
                    },
                    new Category()
                    {
                        CategoryID = 2,
                        CategoryName = "Cerveza",
                        Description = "Está rica",
                        Picture = 456
                    }
                }

           };

        public static IEnumerable<object[]> AddressToAddressDto =>
           new List<object[]>
           {
                new object[]{
                    new Address()
                    {
                        City = "Miami",
                        State = "Florida",
                        Country = new Country{CountryID = 1, CountryNameLong = "Unites States", CountryNameShort = "USA"}
                    },
                    new AddressDto()
                    {
                        Ciudad = "Miami",
                        Estado = "Florida",
                        País = new Country{CountryID = 1, CountryNameLong = "Unites States", CountryNameShort = "USA"}
                    }
                }
           };

        public static IEnumerable<object[]> EmployeeDtoToEmployee =>
         new List<object[]>
         {
                new object[]{
                    new EmployeeDto()
                    {
                        Name = "George",
                        Salary = 1200,
                        Department = "Finance",
                        Address = new AddressDto
                        {
                            Ciudad = "Las Palmas",
                            Estado = "Gran Canaria",
                            País = new Country
                            {
                                CountryID = 1,
                                CountryNameLong = "España",
                                CountryNameShort = "Es"
                            }
                        }
                    },

                    new Employee()
                    {
                        Name = "George",
                        Salary = 1200,
                        Department = "Finance",
                        Address = new Address
                        {
                            City = "Las Palmas",
                            State = "Gran Canaria",
                            Country = new Country
                            {
                                CountryID = 1,
                                CountryNameLong = "España",
                                CountryNameShort = "Es"
                            }
                        }

                    }
                }
         };

        public static IEnumerable<object[]> EmployeeViewModelToEntity =>
            new List<object[]>
            {
                new object[]{

                    new EmployeeViewModel()
                    {
                        EmployeeID = 123,
                        Nombre = "George",
                        Salario = 1200,
                        Departmento = "Finance",
                        Dirección = new Address
                        {
                            City = "Las Palmas",
                            State = "Gran Canaria",
                            Country = new Country
                            {
                                CountryID = 1,
                                CountryNameLong = "España",
                                CountryNameShort = "Es"
                            }
                        },
                        Pedidos= new List<Order>
                        {
                            new Order
                            {
                                OrderID = 4,
                                OrderDate = new DateTime(2021,01, 24),
                                CustomerID = 1024,
                                Category = new Category
                                {
                                    CategoryID = 1,
                                    CategoryName = "Salsas",
                                    Description = "Con queso",
                                    Picture = 10
                                },
                                Country = new Country
                                {
                                    CountryID = 1,
                                    CountryNameLong = "España",
                                    CountryNameShort = "Es"
                                }
                            },

                            new Order
                            {
                                OrderID = 2,
                                OrderDate = new DateTime(2021,12, 24),
                                CustomerID = 1080,
                                Category = new Category
                                {
                                    CategoryID = 4,
                                    CategoryName = "Vinos",
                                    Description = "Rioja",
                                    Picture = 22
                                },
                                Country = new Country
                                {
                                    CountryID = 5,
                                    CountryNameLong = "Francia",
                                    CountryNameShort = "Fr"
                                }
                            }
                        }
                    },

                    new Employee()
                    {
                        EmployeeID = 123,
                        Name = "George",
                        Salary = 1200,
                        Department = "Finance",
                        Address = new Address
                        {
                            City = "Las Palmas",
                            State = "Gran Canaria",
                            Country = new Country
                            {
                                CountryID = 1,
                                CountryNameLong = "España",
                                CountryNameShort = "Es"
                            }
                        },
                        Orders = new List<Order>
                        {
                            new Order
                            {
                                OrderID = 1,
                                OrderDate = new DateTime(2021,01, 24),
                                CustomerID = 1024,
                                Category = new Category
                                {
                                    CategoryID = 1,
                                    CategoryName = "Salsas",
                                    Description = "Con queso",
                                    Picture = 10
                                },
                                Country = new Country
                                {
                                    CountryID = 1,
                                    CountryNameLong = "España",
                                    CountryNameShort = "Es"
                                }
                            },
                            new Order
                            {
                                OrderID = 2,
                                OrderDate = new DateTime(2021,12, 24),
                                CustomerID = 1080,
                                Category = new Category
                                {
                                    CategoryID = 4,
                                    CategoryName = "Vinos",
                                    Description = "Rioja",
                                    Picture = 22
                                },
                                Country = new Country
                                {
                                    CountryID = 5,
                                    CountryNameLong = "Francia",
                                    CountryNameShort = "Fr"
                                }
                            }
                        }
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
                        PictureVm  = 357
                    },
                    new Category()
                    {
                        CategoryID = 1,
                        CategoryName = "Bevarages",
                        Description = "Está buena",
                        Picture = 357
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
                },

                new object[]{
                    new CategoryViewModel()
                    {
                        CategoryIDVm = 1,
                        CategoryNameVm  = "Bevarages",
                        DescriptionVm  = "Está buena",
                        PictureVm  = 123
                    },
                    new Category()
                    {
                        CategoryID = 1,
                        CategoryName = "Bevarages",
                        Description = "Está buena",
                        Picture = 123
                    }
                }
           };
    }
}
