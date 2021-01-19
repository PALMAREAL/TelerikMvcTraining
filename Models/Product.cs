using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.Models
{
    public class Product : Entity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public uint? UnitsInStock { get; set; }
        public uint? UnitsOnOrder { get; set; }
        public uint? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}