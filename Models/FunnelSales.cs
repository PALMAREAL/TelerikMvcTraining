using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.Models
{
    public class FunnelSales
    {
        public FunnelSales(string category, int value)
        {
            Category = category;
            Value = value;
        }
        public string Category { get; set; }

        public int Value { get; set; }
    }
}