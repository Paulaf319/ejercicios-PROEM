using System;

namespace Ejercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entre 0 y 9:");
            int num = int.Parse(Console.ReadLine());

            while(num < 0 || num >9)
            {
                Console.WriteLine("Ingrese un numero entre 0 y 9 inclusive:");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numero ingresado correctamente!");
        }
    }
}
