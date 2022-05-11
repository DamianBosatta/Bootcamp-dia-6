using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ejercicio6
{
    internal class Pila1<t>
    {
        private Stack<t> pila;





        public Pila1()
        {

            pila = new Stack<t>();


        }

        public void CargarDato(t obj)
        {

            pila.Push(obj);





        }

        public void DesapilarPila()
        {


            foreach (t objeto in pila)
            {
                Console.WriteLine(objeto);

            }




        }

    }
}
