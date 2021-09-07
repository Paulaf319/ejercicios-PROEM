using System;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            int num1;
            double num2 = 0; //debe ser double para poder conseguir un prom con punto decimal
            
            Console.WriteLine("A continuacion debera ingresar 5 numeros de manera separada.");

            while(cant < 5)
            {
                Console.WriteLine("Ingrese un numero:");
                num1 = int.Parse(Console.ReadLine());
                cant++;
                num2 = num1 + num2;
            }

            double prom = num2 / cant;
            Console.WriteLine("La suma de los numeros ingresados es " + num2);
            Console.WriteLine("El promedio de los numeros ingresados es " + prom);

        }
    }
}
