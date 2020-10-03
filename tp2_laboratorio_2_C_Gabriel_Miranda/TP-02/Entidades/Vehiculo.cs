using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        private Vehiculo.EMarca marca;
        private string chasis;
        private ConsoleColor color;

        public Vehiculo(string chasis, Vehiculo.EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        protected abstract Vehiculo.ETamanio Tamanio { get; }

        public virtual string Mostrar() => (string)this;

        public static explicit operator string(Vehiculo p)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("CHASIS: {0}\r\n", (object)p.chasis);
            stringBuilder.AppendFormat("MARCA : {0}\r\n", (object)p.marca.ToString());
            stringBuilder.AppendFormat("COLOR : {0}\r\n", (object)p.color.ToString());
            stringBuilder.AppendLine("---------------------");
            return stringBuilder.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2) => v1.chasis == v2.chasis;

        public static bool operator !=(Vehiculo v1, Vehiculo v2) => !(v1.chasis == v2.chasis);

        public enum EMarca
        {
            Chevrolet,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson,
        }

        public enum ETamanio
        {
            Chico,
            Mediano,
            Grande,
        }
    }
}
