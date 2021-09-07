using System;

namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int cant = 0;
            int num = int.Parse(Console.ReadLine());

            if(num <= 0)
            {
                Console.WriteLine("Ingrese un numero valido:");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Los numeros pares del 1 al {0} son:", num);
            for (int c = 1; c <= num; c++)
            {
                
                if(c % 2 == 0)
                {
                    Console.WriteLine(c);
                    cant++;
                }
            }

            Console.WriteLine("Se encontraron {0} numeros pares.", cant);

        }
    }
}
