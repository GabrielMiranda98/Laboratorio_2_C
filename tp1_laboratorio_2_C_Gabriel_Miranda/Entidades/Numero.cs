using System;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, asignará valor 0 al atributo numero.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Sobrecarga de constructor, asignará el numero ingresado por parametro como valor al atributo numero.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Sobrecarga de constructor, hara la conversion de cadena de texto a numero y asignará el valor al atributo numero.
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }
        #endregion

        #region Sobrecarga de operadores

        public static double operator -(Numero n1, Numero n2)
        {

            return (n1.numero - n2.numero);
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double aux=double.MinValue;
            if (n2.numero != 0) { aux= (n1.numero / n2.numero); }
            return aux;
        }
        #endregion

        #region Metodos Publicos

        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido";

            if (EsBinario(binario))
            {
                retorno = Convert.ToInt32(binario, 2).ToString();
            }

            return retorno;
        }

        public string DecimalBinario(double numero)
        {
            int numeroAbsoluto = (int)Math.Abs(numero);
            return Convert.ToString(numeroAbsoluto, 2);
        }

        public string DecimalBinario(string numero)
        {
            string retorno = "Valor inválido";
            double value = 0;
            uint value2 = 0;
            if (double.TryParse(numero, out value))
            {
                if (UInt32.TryParse(numero, out value2))
                {
                    retorno = Convert.ToString(Convert.ToInt32(numero, 10), 2);
                }
            }

            return retorno;

        }
        #endregion

        #region Metodos privados
        private double ValidarNumero(string strNumero)
        {
            if (double.TryParse(strNumero, out double numero))
            {
                return numero;
            }
            else
            {
                return 0;
            }
        }
        private bool EsBinario(string binario)
        {
            foreach (char auxBuscador in binario)
            {
                if (auxBuscador == '1' || auxBuscador == '0')
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Propiedades
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion
    }


}


