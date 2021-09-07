using System;

namespace Ejercicio_38
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos un array e ingresamos los datos que contiene
            int[] numeros = { 2, 4, 5, 6, 8, 10, 1, 3, 7, 9 };

            //ALTERNATIVA
            //int[] numeros = new int[] {2, 4, 5, 6, 8, 10, 1, 3, 7, 9};

            Console.WriteLine("Nuestro array de numeros contiene los siguientes numeros:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
