using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre:");
            string nom = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            int ed = int.Parse(Console.ReadLine());
            Console.WriteLine("Usted es " + nom + " y tiene " + ed + " anios.");
        }
    }
}
