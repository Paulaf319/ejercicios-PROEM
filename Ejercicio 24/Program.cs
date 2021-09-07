using System;

namespace Ejercicio_24
{
    class Program
    {
        static void Main(string[] args)
        {
            const string pass = ".NET";
            Console.WriteLine("Ingrese su clave:");
            string clave = Console.ReadLine();

            while(pass != clave)
            {
                Console.WriteLine("Recuerde respetar mayusculas y minusculas.");
                Console.WriteLine("Ingrese su clave:");
                clave = Console.ReadLine();
            }

            Console.WriteLine("Clave ingresada correctamente!");
            
        }
    }
}
