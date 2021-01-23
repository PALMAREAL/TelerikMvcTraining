using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.Models
{
    public class SalesPerformers : Entity
    {
        public string SalesPerson { get; set; }

        public int SalesAmount { get; set; }
    }
}