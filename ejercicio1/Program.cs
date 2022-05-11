using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ingrese el valor para lado 1 del rectangulo ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ingrese el lado 2 del rectangulo ");
            int lado2 = int.Parse(Console.ReadLine());


            Rectangulo rec1 = new Rectangulo(lado1, lado2);

            rec1.returnSuperficie();
            rec1.returnPerimetro();
        }
    }
}
