using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        private Sedan.ETipo tipo;

        public Sedan(Vehiculo.EMarca marca, string chasis, ConsoleColor color)
          : base(chasis, marca, color)
          => this.tipo = Sedan.ETipo.CuatroPuertas;

        public Sedan(Vehiculo.EMarca marca, string chasis, ConsoleColor color, Sedan.ETipo tipo)
          : base(chasis, marca, color)
          => this.tipo = tipo;

        protected override Vehiculo.ETamanio Tamanio => Vehiculo.ETamanio.Mediano;

        public override sealed string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("SEDAN");
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.AppendFormat("TAMAÑO : {0}", (object)this.Tamanio);
            stringBuilder.AppendLine("TIPO : " + this.tipo.ToString());
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("---------------------");
            return stringBuilder.ToString();
        }

        public enum ETipo
        {
            CuatroPuertas,
            CincoPuertas,
        }
    }
}
