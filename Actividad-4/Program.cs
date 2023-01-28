using System;

namespace Actividad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular sueldo + comision
            float TotalFacturado, Comision, SueldoTotal;
            // Si quiero guardar constantes en una variable:
            // const float SueldoFijo = 15000;
            // const float PorcentajeComision = 0.05F;
            // Cuando pongo const no se puede asignar.
            // Luego Introducirlas en el programa.
            Console.WriteLine("Ingrese el total facturado:");
            TotalFacturado = float.Parse(Console.ReadLine());

            Comision = TotalFacturado * 0.05F;
            // Otra manera Comision = 5 * TotalFacturado / 100;
            // Comision = TotalFacturado - TotalFacturado * 0.95;
            SueldoTotal = Comision + 15000;

            Console.WriteLine("El sueldo Total es: " + SueldoTotal);

        }
    }
}
