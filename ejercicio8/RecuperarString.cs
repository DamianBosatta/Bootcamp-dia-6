
using System;
using System.Collections.Generic;
using System.Text;


namespace ejercicio8
{
    public static class RecuperarString1
    {


        public static string MitadAtras(this String letras) => letras.Substring(0, letras.Length / 2);



        public static string MitadAdelante(this String letra) => letra.Substring(letra.Length / 2);







    }
}

