using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.ViewModels
{
    public class SalesPerformersViewModel : ViewModel<SalesPerformers>
    {
        public string SalesPerson { get; set; }

        public int SalesAmount { get; set; }

        public SalesPerformersViewModel(string salesPerson, int salesAmount)
        {
            SalesPerson = salesPerson;

            SalesAmount = salesAmount;
        }
    }
}