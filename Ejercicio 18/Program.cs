using System;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la hora:");
            int hora = int.Parse(Console.ReadLine());

           if(hora >= 7 || hora <= 11)
            {
                Console.WriteLine("Es de maniana");
            }

        }
    }
}
