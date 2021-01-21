using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.ViewModels
{
    public class SalesPerformersViewModel
    {
        public SalesPerformersViewModel(string salesPerson, int salesAmount)
        {
            SalesPerson = salesPerson;
            SalesAmount = salesAmount;
        }

        public string SalesPerson { get; set; }

        public int SalesAmount { get; set; }
    }
}