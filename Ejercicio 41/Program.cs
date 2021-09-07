using System;


namespace Ejercicio_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamanio de su array:");
            int tamarray = int.Parse(Console.ReadLine());
            int[] numeros = new int[tamarray];
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("{0}Ingrese un numero para guardar en el array:", Environment.NewLine);
                numeros[i] = int.Parse(Console.ReadLine());
                suma = suma + numeros[i];
            }
            Console.WriteLine("{0}Su array contiene los siguientes numeros:", Environment.NewLine);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i, numeros[i]);
            }
            Console.WriteLine("{0}La suma de todos los numeros de su array es {1}.", Environment.NewLine, suma);
        }
    }
}
