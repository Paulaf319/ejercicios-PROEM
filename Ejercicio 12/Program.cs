using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su estado civil:");
            string estciv = Console.ReadLine();
            if(edad < 18 && estciv != "soltero")
            {
                Console.WriteLine("Es muy pequeño para NO ser soltero");
            }
        }
    }
}
