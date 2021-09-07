using System;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un mes del anio:");
            string mes = Console.ReadLine().Trim().ToLower();


            switch (mes)
            {
                case "febrero":
                    Console.WriteLine("este mes tiene 28 dias");
                    break;
                case "abril":
                case "junio":
                case "septiembre":
                case "noviembre":
                    Console.WriteLine("Este mes tiene 30 dias!");
                    break;
                case "enero":
                case "marzo":
                case "mayo":
                case "julio":
                case "agosto":
                case "octubre":
                case "diciembre":
                    Console.WriteLine("este mes tiene 31 dias!");
                    break;
                default:
                    Console.WriteLine("No entendi lo que escribiste");
                    break;
            }
            
        }
    }
}
