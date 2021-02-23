using System.Collections.Generic;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.ViewModels
{
    public class EmployeeViewModel : ViewModel<Employee>
    {
        public int EmployeeID { get; set; }

        public string Nombre { get; set; }

        public int Salario { get; set; }

        public string Departmento { get; set; }

        public Address Dirección { get; set; }

        public IEnumerable<Order> Pedidos { get; set; }

        public override bool Equals(object obj)
        {
            return obj is EmployeeViewModel model &&
                   EmployeeID == model.EmployeeID &&
                   Nombre == model.Nombre &&
                   Salario == model.Salario &&
                   Departmento == model.Departmento &&
                   EqualityComparer<Address>.Default.Equals(Dirección, model.Dirección) &&
                   EqualityComparer<IEnumerable<Order>>.Default.Equals(Pedidos, model.Pedidos);
        }

        public override int GetHashCode()
        {
            int hashCode = -585205438;
            hashCode = hashCode * -1521134295 + EmployeeID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + Salario.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Departmento);
            hashCode = hashCode * -1521134295 + EqualityComparer<Address>.Default.GetHashCode(Dirección);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<Order>>.Default.GetHashCode(Pedidos);
            return hashCode;
        }
    }
}