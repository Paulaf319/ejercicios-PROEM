using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());
            if(edad >= 18)
            {
                Console.WriteLine("Es adulto");
            }
            else if(edad <= 17 && edad >= 13)
            {
                Console.WriteLine("Es adolescente");
            }
            else
            {
                Console.WriteLine("Es ninio");
            }
        }
    }
}
