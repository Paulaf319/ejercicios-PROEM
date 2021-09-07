using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un monto:");
            int mon = int.Parse(Console.ReadLine());
            double tot = mon * 0.75;
            Console.WriteLine("Su total -25% es igual a: " + tot);
        }
    }
}
