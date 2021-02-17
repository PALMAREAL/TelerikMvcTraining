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
    }
}