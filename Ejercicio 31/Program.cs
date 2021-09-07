using System;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A continuacion usted podra ingresar numeros positivos o negativos hasta que desee detenerse.");
            int cant = 0, cantn = 0, cantp = 0, cantz = 0, cantnp = 0, cantni = 0;
            double num, numn = 0, nump = 0;
            string parar = "a";
            double promp, promn;
            double dift;

            while(parar != "s")
            {
                Console.WriteLine("Ingrese un numero:");
                num = double.Parse(Console.ReadLine());
                cant++;

                if(num % 2 == 0)
                {
                    cantnp++;
                }
                else
                {
                    cantni++;
                }


                if(num == 0)
                {
                    cantz++;
                }
                else if(num > 0)
                {
                    nump = nump + num;
                    cantp++;
                }
                else
                {
                    numn = numn + num;
                    cantn++;
                }

                Console.WriteLine("Si desea parar presione 's', si desea continuar presione cualquier tecla.");
                parar = Console.ReadLine();
            }

            promn = numn / cantn;
            promp = nump / cantp;
            dift = nump + numn;

            Console.WriteLine("Usted ha ingresado {0} numeros.{1}{2} de esos {0} numeros eran numeros positivos.{1}{3} de esos {0} numeros eran numeros negativos.{1}Usted ingreso {4} ceros.{1}{5} de los {0} numeros ingresados son numeros pares.{1}{6} de los {0} numeros ingresados son numeros impares.{1}{1}La suma de los {2} numeros positivos es de {7} y su promedio es de {9}.{1}{1}La suma de los {3} numeros negativos es de {8} y su promedio es de {10}.{1}{1}La diferencia entre numeros positivos ({7}) y numeros negativos ({8}) es de {11}.", cant, Environment.NewLine, cantp, cantn, cantz, cantnp, cantni, nump, numn, promp, promn, dift);
        }
    }
}
