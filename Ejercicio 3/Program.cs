using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un monto:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro monto:");
            int num2 = int.Parse(Console.ReadLine());
            int tot = num1 + num2;
            Console.WriteLine("El total es: " + tot);

        }
    }
}
