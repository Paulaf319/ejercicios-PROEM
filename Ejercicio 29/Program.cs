using System;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!{0}A continuacion usted podra ingresar tantos numeros positivos o negativos como desee.{0}Este programa se encargara de sumar los positivos y multiplicar los negativos.", Environment.NewLine);
            string parar = "a";
            int num = 0;
            int nump = 0;
            int cant = 0;
            int cantp = 0;
            int cantn = 0; 
            int totneg = 0;

            while (parar != "s")
            {
                Console.WriteLine("Ingrese un numero positivo o negativo:");
                num = int.Parse(Console.ReadLine());
                cant++;
                if(num >= 0)
                {
                    nump =+ num;
                    cantp++;
                }
                else
                {
                    totneg = totneg * num;

                    while(totneg == 0)
                    {
                        totneg = num;
                    }

                    cantn++;
                    
                }
                Console.WriteLine("Si desea dejar de ingresar datos presione 's'.{0}Si desea continuar presione cualquier tecla.", Environment.NewLine);
                parar = Console.ReadLine();
            }

            Console.WriteLine("Programa detenido.{0}Usted ha ingresado {1} datos.{0}{2} de ellos fueron numeros positivos.{0}{3} de ellos fueron numeros negativos.{0}La suma total de los numeros positivos es de {4}.{0}La multiplicacion de los {3} numeros negativos es de {5}.", Environment.NewLine, cant, cantp, cantn, nump, totneg);
        }
    }
}
