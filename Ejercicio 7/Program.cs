using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());
            if(edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
        }
    }
}
