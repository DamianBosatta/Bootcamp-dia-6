
using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio1
{
    partial class Rectangulo
    {
        public int returnSuperficie()
        {

            int resultado = lado1 * lado2;
            Console.WriteLine(resultado);
            return resultado;

        }

        public int returnPerimetro()
        {
            int resultado = (lado1 + lado1) + (lado2 + lado2);
            Console.WriteLine(resultado);
            return resultado;

        }



    }
}
