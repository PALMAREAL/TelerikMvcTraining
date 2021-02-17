using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.Models
{
    public class Employee : Entity
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        public string Department { get; set; }

        public Address Address { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   Name == employee.Name &&
                   Salary == employee.Salary &&
                   Department == employee.Department &&
                   EqualityComparer<Address>.Default.Equals(Address, employee.Address);
        }

        public override int GetHashCode()
        {
            int hashCode = 2085685211;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Salary.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Department);
            hashCode = hashCode * -1521134295 + EqualityComparer<Address>.Default.GetHashCode(Address);
            return hashCode;
        }
    }
}