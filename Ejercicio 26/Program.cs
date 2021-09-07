using System;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 'f' para femenino o 'm' para masculino:");
            char sex = char.Parse(Console.ReadLine());
            
            while(sex != 'f' && sex != 'm')
            {
                Console.WriteLine("Recuerde respetar las minusculas.");
                Console.WriteLine("Ingrese 'f' para femenino o 'm' para masculino:");
                sex = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Gracias, hemos guardado sus datos.");
        }
    }
}
