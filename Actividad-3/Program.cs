using System;

namespace Actividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa para calcular la el tiempo de ir de un lado a otro
            float km, v, tiempo;
            Console.WriteLine("Ingrese los kilometros:");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad promedio:");
            v = float.Parse(Console.ReadLine());

            tiempo = km / v;
            Console.WriteLine("El tiempo aproximado de llegar de un punto a otro es: " + tiempo.ToString("0.00") + " horas");
            
            
        }
    }
}
