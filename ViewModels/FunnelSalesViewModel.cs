using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.ViewModels
{
    public class FunnelSalesViewModel
    {
        public FunnelSalesViewModel(string category, int value)
        {
            Category = category;
            Value = value;
        }
        public string Category { get; set; }

        public int Value { get; set; }
    }
}
