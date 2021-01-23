using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.ViewModels
{
    public class FunnelSalesViewModel : ViewModel<FunnelSales>
    {
        public string Category { get; set; }

        public int Value { get; set; }
        
        public FunnelSalesViewModel(string category, int value)
        {
            Category = category;

            Value = value;
        }
    }
}
