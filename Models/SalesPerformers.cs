using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.Models
{
    public class SalesPerformers
    {
        public SalesPerformers(string salesPerson, int salesAmount)
        {
            SalesPerson = salesPerson;
            SalesAmount = salesAmount;
        }

        public string SalesPerson { get; set; }

        public int SalesAmount { get; set; }
    }
}