using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.Models
{
    public class Order : Entity
    {
        public int OrderID { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? CustomerID { get; set; }

        public Category Category { get; set; }

        public Country Country { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderID == order.OrderID &&
                   OrderDate == order.OrderDate &&
                   CustomerID == order.CustomerID &&
                   EqualityComparer<Category>.Default.Equals(Category, order.Category) &&
                   EqualityComparer<Country>.Default.Equals(Country, order.Country);
        }

        public override int GetHashCode()
        {
            int hashCode = 1806210779;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderDate.GetHashCode();
            hashCode = hashCode * -1521134295 + CustomerID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Category>.Default.GetHashCode(Category);
            hashCode = hashCode * -1521134295 + EqualityComparer<Country>.Default.GetHashCode(Country);
            return hashCode;
        }
    }
}