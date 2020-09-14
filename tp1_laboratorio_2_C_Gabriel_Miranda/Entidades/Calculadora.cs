using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    /// <summary>
    /// Clase Estatica encargada de realizar operaciones de suma, resta, división y multiplicación de dos números.
    /// </summary>

    public static class Calculadora
    {

        #region Metodos Estaticos
        /// <summary>
        /// Verifica que lo recibido es valido y hace la operación seleccionada
        /// </summary>
        /// </summary>
        /// <param name="num1">Primer dato Numero</param>
        /// <param name="num2">Segundo dato Numero</param>
        /// <param name="operador">Operacion a realizar</param>
        /// <returns>Retornara el resultado de la operacion, o en caso de una division por 0, retornará double.MinValue.</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {

            double resultado = 0;
            char aux;
            if (char.TryParse(operador, out aux))
            
                switch (ValidarOperador(aux))
                {
                    case "+":
                        resultado = (num1 + num2);
                        break;
                    case "-":
                        resultado = (num1 - num2);
                        break;
                    case "*":
                        resultado = (num1 * num2);
                        break;
                    case "/":
                        resultado = (num1 / num2);
                        break;
                    default:
                        break;
                }
            
            return resultado;

        }

        /// <summary>
        /// Valida el operador si es + / * -
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>El operador seleccionado, caso contrario retornara + </returns>
        private static string ValidarOperador(char operador)
        {

            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {

                return operador.ToString();

            }
            else
            {

                return "+";
            }


        }
        #endregion

    }
}


