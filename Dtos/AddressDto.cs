using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.Dtos
{
    public class AddressDto
    {
        public string Ciudad { get; set; }

        public string Estado { get; set; }

        public Country País { get; set; }
    }
}