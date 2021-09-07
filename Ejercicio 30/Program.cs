using System;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            bool flag;

            do
            {
                Console.WriteLine("Ingrese un numero a comprobar, para detenerse ingrese una letra:");
                flag = int.TryParse(Console.ReadLine(), out numero);
                if(numero < minimo)
                {
                    minimo = numero;
                }
                if(numero > maximo)
                {
                    maximo = numero;
                }

            } while (flag);

            Console.WriteLine("El numero maximo ingresado es {0}.", maximo);
            Console.WriteLine("El numero minimo ingesado es {0}.", minimo);
        }
    }
}
