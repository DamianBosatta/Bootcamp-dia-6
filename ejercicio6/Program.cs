using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            Pila1<int> p1 = new Pila1<int>();



            int num = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" ingrese numeros enteros ");
                num = int.Parse(Console.ReadLine());
                p1.CargarDato(num);
            }

            p1.DesapilarPila();
        }
    }
}