using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.Dtos
{
    public class EmployeeDto
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        public string Department { get; set; }

        public AddressDto Address { get; set; }
    }
}