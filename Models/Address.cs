using System.Collections.Generic;

namespace TelerikMvcTraining.Models
{
    public class Address : Entity
    {
        public string City { get; set; }

        public string State { get; set; }

        public Country Country { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Address address &&
                   City == address.City &&
                   State == address.State &&
                   EqualityComparer<Country>.Default.Equals(Country, address.Country);
        }

        public override int GetHashCode()
        {
            int hashCode = -1594001927;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(State);
            hashCode = hashCode * -1521134295 + EqualityComparer<Country>.Default.GetHashCode(Country);
            return hashCode;
        }
    }
}