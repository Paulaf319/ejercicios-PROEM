using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el mes:");
            string mes = Console.ReadLine().Trim().ToLower();

            switch(mes)
            {
                case "septiembre":
                case "octubre":
                case "noviembre":
                case "diciembre":
                case "enero":
                case "febrero":
                case "marzo":
                    Console.WriteLine("Ya pasamos frio, ahora calor!");
                    break;
                case "abril":
                case "mayo":
                case "junio":
                    Console.WriteLine("Falta para el invierno.");
                    break;
                case "julio":
                case "agosto":
                    Console.WriteLine("Abrigate que hace frio!");
                    break;
                default:
                    Console.WriteLine("No entendi lo que escribiste");
                    break;
            }

            //ALTERNATIVA NUMERICA
            
            Console.WriteLine("Ingresa el mes:");
            int mesnum = int.Parse(Console.ReadLine());

            switch(mesnum)
            {
                case 9:
                case 10:
                case 11:
                case 12:
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Ya pasamos frio, ahora calor!");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Falta para el invierno.");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Abrigate que hace frio!");
                    break;
                default:
                    Console.WriteLine("No entendi lo que escribiste, ingresa un numero");
                    break;
            }
            
        }
    }
}
