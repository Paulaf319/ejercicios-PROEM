using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un mes:");
            string mes = Console.ReadLine();
            
            switch(mes)
            {
                case "enero":
                    Console.WriteLine("Que comiences bien el anio!");
                    break;
                case "marzo":
                    Console.WriteLine("A clases!");
                    break;
                case "julio":
                    Console.WriteLine("Se vienen las vacaciones!");
                    break;
                case "diciembre":
                    Console.WriteLine("Felices fiestas!");
                    break;
            }

            //ALTERNATIVA UTILIZANDO UN STRING COMO MENSAJE
            string mensaje;

            switch (mes)
            {
                case "enero":
                    mensaje = "Que comiences bien el anio!";
                    Console.WriteLine(mensaje);
                    break;
                case "marzo":
                    mensaje = "A clases!";
                    Console.WriteLine(mensaje);
                    break;
                case "julio":
                    mensaje = "Se vienen las vacaciones!";
                    Console.WriteLine(mensaje);
                    break;
                case "diciembre":
                    mensaje = "Felices fiestas!";
                    Console.WriteLine(mensaje);
                    break;
            }
        }
    }
}
