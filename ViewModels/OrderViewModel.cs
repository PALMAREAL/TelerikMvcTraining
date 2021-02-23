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

        public override bool Equals(object obj)
        {
            return obj is OrderViewModel model &&
                   IdOrden == model.IdOrden &&
                   FechaCompra == model.FechaCompra &&
                   ClienteId == model.ClienteId &&
                   EqualityComparer<Category>.Default.Equals(Categoría, model.Categoría) &&
                   EqualityComparer<Country>.Default.Equals(País, model.País);
        }

        public override int GetHashCode()
        {
            int hashCode = 1226852174;
            hashCode = hashCode * -1521134295 + IdOrden.GetHashCode();
            hashCode = hashCode * -1521134295 + FechaCompra.GetHashCode();
            hashCode = hashCode * -1521134295 + ClienteId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Category>.Default.GetHashCode(Categoría);
            hashCode = hashCode * -1521134295 + EqualityComparer<Country>.Default.GetHashCode(País);
            return hashCode;
        }
    }
}