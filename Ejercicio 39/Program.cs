using System;

namespace Ejercicio_39
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alumnos = { "Pablo", "Lucia", "Ricardo", "Norma", "Alejandro" };
            Console.WriteLine("Los alumnos son:{0}", Environment.NewLine);

            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine(alumnos[i]);
            }
        }
    }
}
