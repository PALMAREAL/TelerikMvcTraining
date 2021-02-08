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

        
        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   ProductID == product.ProductID &&
                   ProductName == product.ProductName &&
                   SupplierID == product.SupplierID &&
                   CategoryID == product.CategoryID &&
                   QuantityPerUnit == product.QuantityPerUnit &&
                   UnitPrice == product.UnitPrice &&
                   UnitsInStock == product.UnitsInStock &&
                   UnitsOnOrder == product.UnitsOnOrder &&
                   ReorderLevel == product.ReorderLevel &&
                   Discontinued == product.Discontinued;
        }

        public override int GetHashCode()
        {
            int hashCode = 1026538735;
            hashCode = hashCode * -1521134295 + ProductID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductName);
            hashCode = hashCode * -1521134295 + SupplierID.GetHashCode();
            hashCode = hashCode * -1521134295 + CategoryID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(QuantityPerUnit);
            hashCode = hashCode * -1521134295 + UnitPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + UnitsInStock.GetHashCode();
            hashCode = hashCode * -1521134295 + UnitsOnOrder.GetHashCode();
            hashCode = hashCode * -1521134295 + ReorderLevel.GetHashCode();
            hashCode = hashCode * -1521134295 + Discontinued.GetHashCode();
            return hashCode;
        }
    }
}