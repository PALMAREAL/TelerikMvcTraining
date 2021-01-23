using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.Models
{
    public class ProductCategories : Entity
    {
        public string Year { get; set; }

        public int VacantLand { get; set; }

        public int ResidentialProperties { get; set; }

        public int CommercialProperties { get; set; }

        public int Total { get; set; }
    }
}