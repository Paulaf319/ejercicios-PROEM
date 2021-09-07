using System;

namespace Ejercicios_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamanio del array:");
            int numero = int.Parse(Console.ReadLine());
            int[] numeros = new int[numero];
   
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("ingrese un numero a guardar en el array");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0}Usted creo un array de {1} numeros que contiene los siguientes numeros:", Environment.NewLine, numero);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }


        }
    }
}
