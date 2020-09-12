using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {




    }

    /*
       Respetando los siguientes diagramas,indicaciones, y lo visto en la cursada, así como reutilizando código cada vez 
    que sea posible, realizar una calculadora de operaciones básicas:Generar un proyecto llamado Entidades
    con las siguientes clases:
    Clase estática Calculadora:•El método ValidarOperador será privado y estático. 
    Deberá validar que el operador recibido sea  
    Caso contrario retornará +.
    •El método Operar será de clase: validará y realizará la operación pedida entre ambos números.
     */
    /// <summary>
    /// Clase Estatica encargada de realizar operaciones de +, -, / o *.
    /// </summary>
    public static class Calculadora {
        #region Metodos
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
            

                switch (ValidarOperador(operador))
                {
                    case "+":
                        resultado = (num1+num2);
                        break;
                    case "-":
                        resultado = (num1-num2);
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

        private static string ValidarOperador(string operador)
        {

            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {

                return operador;

            }
            else{

                return "+";
            }


        }
        #endregion



    }

}
