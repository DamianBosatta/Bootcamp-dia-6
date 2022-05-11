using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio1
{ 
    partial class Rectangulo
    {
        int lado1;
        int lado2;

        private int Lado1 { get => lado1; set => lado1 = value; }
        private int Lado2 { get => lado2; set => lado2 = value; }


        public Rectangulo(int l1, int l2)
        {
            this.lado1 = l1;
            this.lado2 = l2;

        }
    }

}
