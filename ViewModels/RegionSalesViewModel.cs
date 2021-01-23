using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.ViewModels
{
    public class RegionSalesViewModel : ViewModel<RegionSales>
    {
        public string Region { get; set; }

        public double Sales { get; set; }

        public RegionSalesViewModel(string region, double sales)
        {
            Region = region;

            Sales = sales;
        }
    }
}
