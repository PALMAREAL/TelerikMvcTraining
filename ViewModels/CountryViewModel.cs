using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.ViewModels
{
    public class CountryViewModel : ViewModel<Country>
    {
        public byte CountryID { get; set; }

        public string CountryNameShort { get; set; }

        public string CountryNameLong { get; set; }
    }
}