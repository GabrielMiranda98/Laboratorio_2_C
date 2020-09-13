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
            return (n1.numero / n2.numero);
        }
        #endregion
        
        #region Metodos Publicos

        public string BinarioDecimal(string binario)
        {
            double n = 0;

            if (EsBinario(binario))
            {
                for (int i = 0; i < binario.Length - 1; i++)
                {


                }

            }



        }

        public string DecimalBinario(double numero)
        {
            int numeroAbsoluto = (int)Math.Abs(numero);
            return Convert.ToString(numeroAbsoluto, 2);
        }

        public string DecimalBinario(string numero)
        {


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


