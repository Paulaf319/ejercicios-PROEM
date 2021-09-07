using System;

namespace Ejercicio_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcularemos la suma acumulada y el promedio de la cantidad de numeros que usted desee ingresar.");
            int cant = 0;
            int num1 = 0;
            double num2 = 0;
            string parar = "a";

            while(parar != "s")
            {
                Console.WriteLine("Ingrese un numero:");
                num1 = int.Parse(Console.ReadLine());
                cant++;
                num2 = num1 + num2;
                Console.WriteLine("Para detenerse escriba 's' si desea continuar ingresando datos presione cualquier tecla");
                parar = Console.ReadLine();
            }

            double prom = num2 / cant;
            Console.WriteLine("Usted ingreso " + cant + " datos numericos, cuya suma total es " + num2 + ". El promedio es de " + prom);
        }
    }
}
