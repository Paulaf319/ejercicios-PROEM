using System;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("AGENCIA DE VIAJES 'VERANO ETERNO'");
            Console.WriteLine("Para saber a donde se puede viajar seleccione la estacion:");
            Console.WriteLine("1 - Invierno");
            Console.WriteLine("2 - Verano");
            Console.WriteLine("3 - Otonio");
            Console.WriteLine("4 - Primavera");
            int estacion = int.Parse(Console.ReadLine());

            switch (estacion)
            {
                case 1:
                    Console.WriteLine("Usted ha seleccionado Invierno.");
                    Console.WriteLine("Bariloche: SE VIAJA!.");
                    Console.WriteLine("Cordoba: NO se viaja.");
                    Console.WriteLine("Mar del Plata: NO se viaja.");
                    Console.WriteLine("Cataratas: NO se viaja.");
                    break;

                case 2:
                    Console.WriteLine("Usted ha seleccionado Verano.");
                    Console.WriteLine("Bariloche: NO se viaja.");
                    Console.WriteLine("Cordoba: NO se viaja.");
                    Console.WriteLine("Mar del Plata: SE VIAJA!.");
                    Console.WriteLine("Cataratas: SE VIAJA!.");
                    break;

                case 3:

                    Console.WriteLine("Usted ha seleccionado Otonio.");
                    Console.WriteLine("Bariloche: SE VIAJA!.");
                    Console.WriteLine("Cordoba: SE VIAJA!.");
                    Console.WriteLine("Mar del Plata: SE VIAJA!.");
                    Console.WriteLine("Cataratas: SE VIAJA!.");
                    break;

                case 4:

                    Console.WriteLine("Usted ha seleccionado Primavera.");
                    Console.WriteLine("Bariloche: NO se viaja.");
                    Console.WriteLine("Cordoba: SE VIAJA!.");
                    Console.WriteLine("Mar del Plata: SE VIAJA!.");
                    Console.WriteLine("Cataratas: SE VIAJA!.");
                    break;


            }
        }
    }
}
