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

        public override bool Equals(object obj)
        {
            return obj is CountryViewModel model &&
                   CountryID == model.CountryID &&
                   CountryNameShort == model.CountryNameShort &&
                   CountryNameLong == model.CountryNameLong;
        }

        public override int GetHashCode()
        {
            int hashCode = 1539803652;
            hashCode = hashCode * -1521134295 + CountryID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CountryNameShort);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CountryNameLong);
            return hashCode;
        }
    }
}