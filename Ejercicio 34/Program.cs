using System;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de veces que desea ver el mensaje:");
            int n = int.Parse(Console.ReadLine());

            for (int m = 0; m != n; m++)
            {
                Console.WriteLine("Hola Mundo!");
            }
        }
    }
}
