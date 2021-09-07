using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un monto:");
            double mont = double.Parse(Console.ReadLine());
            double tot = mont * 1.1;
            Console.WriteLine("El monto +10% es igual a: " + tot);
        }
    }
}
