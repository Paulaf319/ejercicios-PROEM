using System;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un mes del anio:");
            string mes = Console.ReadLine().ToLower().Trim();

            if(mes == "febrero")
            {
                Console.WriteLine("este mes no tiene mas de 29 dias!");
            }
            else
            {
                Console.WriteLine("este mes tiene 30 dias o mas!");
            }
        }
    }
}
