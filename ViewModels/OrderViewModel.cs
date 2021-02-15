using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.ViewModels
{
    public class OrderViewModel : ViewModel<Order>
    {
        public int IdOrden { get; set; }

        public DateTime? FechaCompra { get; set; }

        public int? ClienteId { get; set; }

        public Category Categoría { get; set; }

        public Country País { get; set; }
    }
}