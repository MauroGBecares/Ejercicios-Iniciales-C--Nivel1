using System;

namespace Actividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r;
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());

            r = n * n * n;

            Console.WriteLine("El resultado es: " + r);
        }
    }
}
