using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWeb
{
    public class Factorial
    {
        public double Calcular(int numero)
        {
            double resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}