using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraWeb
{
    public partial class Default : System.Web.UI.Page
    {
        Suma suma = new Suma();
        Resta resta = new Resta();
        Multiplicacion multiplicacion = new Multiplicacion();
        Division division = new Division();
        PotenciaCuadrado cuadrado = new PotenciaCuadrado();
        PotenciaCubo cubo = new PotenciaCubo();
        RaizCuadrada raiz = new RaizCuadrada();
        Factorial factorial = new Factorial();
        Fibonacci fibonacci = new Fibonacci();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            lresultado.Text += "1";
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            lresultado.Text += "2";
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            lresultado.Text += "3";
        }

        protected void b4_Click(object sender, EventArgs e)
        {
            lresultado.Text += "4";
        }

        protected void b5_Click(object sender, EventArgs e)
        {
            lresultado.Text += "5";
        }

        protected void b6_Click(object sender, EventArgs e)
        {
            lresultado.Text += "6";
        }

        protected void b7_Click(object sender, EventArgs e)
        {
            lresultado.Text += "7";
        }

        protected void b8_Click(object sender, EventArgs e)
        {
            lresultado.Text += "8";
        }

        protected void b9_Click(object sender, EventArgs e)
        {
            lresultado.Text += "9";
        }

        protected void b0_Click(object sender, EventArgs e)
        {
            lresultado.Text += "0";
        }

        protected void bsuma_Click(object sender, EventArgs e) 
        {
            try
            {
                Operadores.numero1 = Convert.ToDouble(lresultado.Text);

                Operadores.suma = true;

                lresultado.Text = "";
            }
            catch
            {
                lresultado.Text = "Error";
            }
        }

        protected void bresta_Click(object sender, EventArgs e) 
        {
            try
            {
                Operadores.numero1 = Convert.ToDouble(lresultado.Text);

                Operadores.resta = true;

                lresultado.Text = "";
            }
            catch
            {
                lresultado.Text = "Error";
            }

        }

        protected void bmulti_Click(object sender, EventArgs e) 
        {
            try
            {
                Operadores.numero1 = Convert.ToDouble(lresultado.Text);

                Operadores.multiplicacion = true;

                lresultado.Text = "";
            }
            catch
            {
                lresultado.Text = "Error";
            }

        }

        protected void bdivision_Click(object sender, EventArgs e) 
        {
            try
            {
                Operadores.numero1 = Convert.ToDouble(lresultado.Text);

                Operadores.division = true;

                lresultado.Text = "";
            }
            catch
            {
                lresultado.Text = "Error";
            }
        }

        protected void bigual_Click(object sender, EventArgs e) 
        {
            try
            {
                if (Operadores.suma)
                {
                    double numero2 = Convert.ToDouble(lresultado.Text);

                    lresultado.Text = suma.Calcular(Operadores.numero1, numero2).ToString();

                    Operadores.suma = false;
                }

                if (Operadores.resta)
                {
                    double numero2 = Convert.ToDouble(lresultado.Text);

                    lresultado.Text = resta.Calcular(Operadores.numero1, numero2).ToString();

                    Operadores.resta = false;
                }

                if (Operadores.multiplicacion)
                {
                    double numero2 = Convert.ToDouble(lresultado.Text);

                    lresultado.Text = multiplicacion.Calcular(Operadores.numero1, numero2).ToString();

                    Operadores.multiplicacion = false;
                }

                if (Operadores.division)
                {
                    double numero2 = Convert.ToDouble(lresultado.Text);

                    lresultado.Text = division.Calcular(Operadores.numero1, numero2).ToString();

                    Operadores.division = false;
                }
            }
            catch
            {
                lresultado.Text = "Error";
            }

        }

        protected void blimpiar_Click(object sender, EventArgs e) 
        {
            lresultado.Text = "";

            Operadores.numero1 = 0;

            Operadores.suma = false;
            Operadores.resta = false;
            Operadores.multiplicacion = false;
            Operadores.division = false;
        }

        protected void bcuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = Convert.ToDouble(lresultado.Text);

                lresultado.Text = cuadrado.Calcular(numero).ToString();
            }
            catch
            {
                lresultado.Text = "Error";
            }
        }

        protected void bcubo_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = Convert.ToDouble(lresultado.Text);

                lresultado.Text = cubo.Calcular(numero).ToString();
            }
            catch
            {
                lresultado.Text = "Error";
            }
        }

        protected void braiz_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = Convert.ToDouble(lresultado.Text);

                lresultado.Text = raiz.Calcular(numero).ToString();
            }
            catch
            {
                lresultado.Text = "Error";
            }
        }

        protected void bfactorial_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(lresultado.Text);

                lresultado.Text = factorial.Calcular(numero).ToString();
            }
            catch
            {
                lresultado.Text = "Error";
            }
        }

        protected void bfibonacci_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(lresultado.Text);

                lresultado.Text = fibonacci.Calcular(numero);
            }
            catch
            {
                lresultado.Text = "Error";
            }
        }
    }
}