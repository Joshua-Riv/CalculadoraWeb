using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWeb
{
    public class Division
    {
        public double Calcular(double n1, double n2)
        {
            if (n2 == 0)
                throw new Exception("No se puede dividir entre cero.");

            return n1 / n2;
        }
    }
}