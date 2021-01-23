using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.ViewModels
{
    public class ProductCategoriesViewModel : ViewModel<ProductCategories>
    {

        public string Year { get; set; }

        public int VacantLand { get; set; }

        public int ResidentialProperties { get; set; }

        public int CommercialProperties { get; set; }

        public int Total { get; set; }

        public ProductCategoriesViewModel(string year, int vacantLand, int residentialProperties, int commercialProperties, int total)
        {
            Year = year;

            VacantLand = vacantLand;

            ResidentialProperties = residentialProperties;

            CommercialProperties = commercialProperties;

            Total = total;
        }
    }
}