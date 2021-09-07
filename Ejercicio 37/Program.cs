using System;

namespace Ejercicio_37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int num = int.Parse(Console.ReadLine());
            int n = num / 2;

            for (int i = 2; i <= n; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine("El numero no es primo.");
                    break;
                }
                else
                {
                    Console.WriteLine("El numero es primo.");
                    break;
                }
            }
        }
    }
}
