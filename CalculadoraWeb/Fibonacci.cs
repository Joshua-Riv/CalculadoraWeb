using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWeb
{
    public class Fibonacci
    {
        public string Calcular(int numero)
        {
            int primero = 0;
            int segundo = 1;

            string resultado = "";

            for (int i = 0; i < numero; i++)
            {
                resultado += primero + " ";

                int siguiente = primero + segundo;

                primero = segundo;
                segundo = siguiente;
            }

            return resultado;
        }
    }
}