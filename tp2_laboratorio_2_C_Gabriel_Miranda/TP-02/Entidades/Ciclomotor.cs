using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(Vehiculo.EMarca marca, string chasis, ConsoleColor color)
          : base(chasis, marca, color)
        {
        }

        protected override Vehiculo.ETamanio Tamanio => Vehiculo.ETamanio.Chico;

        public override sealed string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("CILOMOTOR");
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.AppendFormat("TAMAÑO : {0}", (object)this.Tamanio);
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("---------------------");
            return stringBuilder.ToString();
        }
    }
}
