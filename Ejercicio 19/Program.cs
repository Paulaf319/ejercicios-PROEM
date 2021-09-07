using System;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la hora");
            int hora = int.Parse(Console.ReadLine());

            switch(hora)
            {
                case 20:
                case 21:
                case 22:
                case 23:
                case 00:
                case 01:
                case 02:
                case 03:
                case 04:
                case 05:
                case 06:
                    Console.WriteLine("Es de noche.");
                    break;
                case 07:
                case 08:
                case 09:
                case 10:
                case 11:
                    Console.WriteLine("Es de maniana.");
                    break;
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    Console.WriteLine("Es de tarde.");
                    break;
                default:
                    Console.WriteLine("La hora no existe.");
                    break;
            }
        }
    }
}
