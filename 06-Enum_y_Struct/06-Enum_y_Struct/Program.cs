using System;

namespace _06_Enum_y_Struct
{
    enum EstacionesAnio
    {
        Primavera = 1, 
        Verano = 2, 
        Otonio = 3, 
        Invierno = 4
    };

    enum Bono
    {
        bajo = 500,
        normal = 1000,
        bueno = 2000,
        extra = 4000
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            EstacionesAnio verEstacion = EstacionesAnio.Invierno;
            System.Console.WriteLine( $"El frio comienza en la estacion: { verEstacion.ToString() }" );

            Bono bonoBryan = Bono.extra;
            Empleado empleadoBryan = new Empleado(15000.45, bonoBryan);
            Console.WriteLine( $"El salario de bryan con el bono es L.{ empleadoBryan.getSalarioConBono() }" );
        }
    }
}
