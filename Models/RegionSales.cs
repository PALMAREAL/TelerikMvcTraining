using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.Models
{
    public class RegionSales : Entity
    {
        public string Region { get; set; }

        public double Sales { get; set; }
    }
}