using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.ViewModels
{
    public class RegionSalesViewModel
    {
        public RegionSalesViewModel(string region, double sales)
        {
            Region = region;
            Sales = sales;
        }

        public string Region { get; set; }

        public double Sales { get; set; }
    }
}
