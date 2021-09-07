using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());
            if (edad == 15)
            {
                Console.WriteLine("Quinceaniero/a");
            }
        }
    }
}
