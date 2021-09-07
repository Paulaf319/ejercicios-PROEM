using System;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tarifabase = 15000;
            Console.WriteLine("AGENCIA DE VIAJES 'VERANO ETERNO' - CALCULADORA DE TARIFAS");
            Console.WriteLine("----- La tarifa base siempre es 15.000 --------");
            Console.WriteLine("Para calcular la tarifa a abonar seleccione la localidad deseada:");
            Console.WriteLine("1 - Bariloche");
            Console.WriteLine("2 - Cordoba");
            Console.WriteLine("3 - Mar del Plata");
            Console.WriteLine("4 - Cataratas");
            int localidad = int.Parse(Console.ReadLine());

            switch(localidad)
            {
                case 1:
                    Console.WriteLine("Usted ha seleccionado Bariloche.");
                    Console.WriteLine("Ahora seleccione la estacion del anio:");
                    Console.WriteLine("1 - Invierno");
                    Console.WriteLine("2 - Verano");
                    Console.WriteLine("3 - Otonio/Primavera");
                    double estB = int.Parse(Console.ReadLine());

                    switch(estB)
                    {
                        case 1:
                            Console.WriteLine("Usted selecciono Bariloche durante invierno");
                            estB = tarifabase * 1.20;
                            Console.WriteLine("La tarifa a pagar es: " + estB);
                            break;

                        case 2:
                            Console.WriteLine("Usted selecciono Bariloche durante verano");
                            estB = tarifabase * 0.8;
                            Console.WriteLine("La tarifa a pagar es: " + estB);
                            break;

                        case 3:
                            Console.WriteLine("Usted selecciono Bariloche durante otinio/primavera");
                            estB = tarifabase * 1.10;
                            Console.WriteLine("La tarifa a pagar es: " + estB);
                            break;
                    }

                    break;
                    
                case 2:
                    Console.WriteLine("Usted ha seleccionado Cordoba.");
                    Console.WriteLine("Ahora seleccione la estacion del anio:");
                    Console.WriteLine("1 - Invierno");
                    Console.WriteLine("2 - Verano");
                    Console.WriteLine("3 - Otonio/Primavera");
                    double estC = int.Parse(Console.ReadLine());

                    switch (estC)
                    {
                        case 1:
                            Console.WriteLine("Usted selecciono Cordoba durante invierno");
                            estC = tarifabase * 0.9;
                            Console.WriteLine("La tarifa a pagar es: " + estC);
                            break;

                        case 2:
                            Console.WriteLine("Usted selecciono Cordoba durante verano");
                            estC = tarifabase * 1.10;
                            Console.WriteLine("La tarifa a pagar es: " + estC);
                            break;

                        case 3:
                            Console.WriteLine("Usted selecciono Cordoba durante otinio/primavera");
                            estC = tarifabase;
                            Console.WriteLine("La tarifa a pagar es: " + estC);
                            break;
                    }

                    break;

                case 3:

                    Console.WriteLine("Usted ha seleccionado Mar del Plata.");
                    Console.WriteLine("Ahora seleccione la estacion del anio:");
                    Console.WriteLine("1 - Invierno");
                    Console.WriteLine("2 - Verano");
                    Console.WriteLine("3 - Otonio/Primavera");
                    double estM = int.Parse(Console.ReadLine());

                    switch (estM)
                    {
                        case 1:
                            Console.WriteLine("Usted selecciono Mar del Plata durante invierno");
                            estM = tarifabase * 0.8;
                            Console.WriteLine("La tarifa a pagar es: " + estM);
                            break;

                        case 2:
                            Console.WriteLine("Usted selecciono Mar del Plata durante verano");
                            estM = tarifabase * 1.20;
                            Console.WriteLine("La tarifa a pagar es: " + estM);
                            break;

                        case 3:
                            Console.WriteLine("Usted selecciono Mar del Plata durante otinio/primavera");
                            estM = tarifabase * 1.10;
                            Console.WriteLine("La tarifa a pagar es: " + estM);
                            break;
                    }

                    break;

                case 4:
                    Console.WriteLine("Usted ha seleccionado Cataratas.");
                    Console.WriteLine("Ahora seleccione la estacion del anio:");
                    Console.WriteLine("1 - Invierno");
                    Console.WriteLine("2 - Verano");
                    Console.WriteLine("3 - Otonio/Primavera");
                    double estK = int.Parse(Console.ReadLine());

                    switch (estK)
                    {
                        case 1:
                            Console.WriteLine("Usted selecciono Cataratas durante invierno");
                            estK = tarifabase * 0.9;
                            Console.WriteLine("La tarifa a pagar es: " + estK);
                            break;

                        case 2:
                            Console.WriteLine("Usted selecciono Cataratas durante verano");
                            estK = tarifabase * 1.10;
                            Console.WriteLine("La tarifa a pagar es: " + estK);
                            break;

                        case 3:
                            Console.WriteLine("Usted selecciono Cataratas durante otinio/primavera");
                            estK = tarifabase * 1.10;
                            Console.WriteLine("La tarifa a pagar es: " + estK);
                            break;
                    }

                    break;


            }


        }
    }
}
