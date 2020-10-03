using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;

        private Taller() => this.vehiculos = new List<Vehiculo>();

        public Taller(int espacioDisponible)
          : this()
          => this.espacioDisponible = espacioDisponible;

        public override string ToString() => Taller.Listar(this, Taller.ETipo.Todos);

        public static string Listar(Taller t, Taller.ETipo tipo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", (object)t.vehiculos.Count, (object)t.espacioDisponible);
            stringBuilder.AppendLine("");
            foreach (Vehiculo vehiculo in t.vehiculos)
            {
                switch (tipo)
                {
                    case Taller.ETipo.Ciclomotor:
                        if (vehiculo is Ciclomotor)
                        {
                            stringBuilder.AppendLine(vehiculo.Mostrar());
                            break;
                        }
                        break;
                    case Taller.ETipo.Sedan:
                        if (vehiculo is Sedan)
                        {
                            stringBuilder.AppendLine(vehiculo.Mostrar());
                            break;
                        }
                        break;
                    case Taller.ETipo.SUV:
                        if (vehiculo is Suv)
                        {
                            stringBuilder.AppendLine(vehiculo.Mostrar());
                            break;
                        }
                        break;
                    default:
                        stringBuilder.AppendLine(vehiculo.Mostrar());
                        break;
                }
            }
            return stringBuilder.ToString();
        }

        public static Taller operator +(Taller t, Vehiculo vehiculo)
        {
            if (t.vehiculos.Count >= t.espacioDisponible)
                return t;
            foreach (Vehiculo vehiculo1 in t.vehiculos)
            {
                if (vehiculo1 == vehiculo)
                    return t;
            }
            t.vehiculos.Add(vehiculo);
            return t;
        }

        public static Taller operator -(Taller t, Vehiculo vehiculo)
        {
            for (int index = 0; index < t.vehiculos.Count; ++index)
            {
                if (t.vehiculos[index] == vehiculo)
                {
                    t.vehiculos.RemoveAt(index);
                    break;
                }
            }
            return t;
        }

        public enum ETipo
        {
            Ciclomotor,
            Sedan,
            SUV,
            Todos,
        }
    }
}
