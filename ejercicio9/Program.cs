using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona obj = new Persona("Lucas", 32);
            Console.WriteLine($"{obj.Nombre} ES MAYOR DE EDAD:{obj.esMayor()}");
        }
    }
}
