using System;

namespace TelerikMvcTraining.Models
{
    public class DetailProduct : Entity
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public string QuantityPerUnit { get; set; }

        public bool Discontinued { get; set; }

        public int? UnitsOnOrder { get; set; }

        public int? CategoryID { get; set; }

        public byte? CountryID { get; set; }

        public byte? CustomerRating { get; set; }

        public int? TargetSales { get; set; }

        public DateTime? LastSupply { get; set; }

        public virtual Category Category { get; set; }

        public virtual Country Country { get; set; }
    }
}