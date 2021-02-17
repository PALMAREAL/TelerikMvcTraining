using System.Collections.Generic;

namespace TelerikMvcTraining.Models
{
    public class Country : Entity
    {
        public int CountryID { get; set; }

        public string CountryNameShort { get; set; }

        public string CountryNameLong { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Country country &&
                   CountryID == country.CountryID &&
                   CountryNameShort == country.CountryNameShort &&
                   CountryNameLong == country.CountryNameLong;
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