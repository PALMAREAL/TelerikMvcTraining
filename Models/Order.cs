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
    }
}