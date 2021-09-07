using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());
            if (edad < 13 || edad > 17)
            {
                Console.WriteLine("Usted no es adolescente");
            }
            else
            {
                Console.WriteLine("Usted es adolescente");
            }
        }
    }
}
