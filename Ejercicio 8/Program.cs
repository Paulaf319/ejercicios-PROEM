﻿using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");
            }
        }
    }
}
