using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _00_EjemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo = new Circulo();
            Console.WriteLine($"Area Circulo: { miCirculo.GetAreCirculo(5) }");

            Conversion monedaCantidad = new Conversion();
            monedaCantidad.GetDolar(24.68);
            Console.WriteLine( $"12500 Lps a Dolares => { monedaCantidad.GetConversionLps( 12500 ) }" );
        }
    }

    class Circulo
    {
        // PROPIEDADES
        private const double PI = 3.141516;

        // METODOS
        public double GetAreCirculo ( int radio )
        {
            return ((PI) * radio * radio);
        }

    }

    class Conversion
    {
        private double dolar = 24.71;
        public double GetConversionLps ( double cantidadLps)
        {
            return cantidadLps / this.dolar;
        }

        public void GetDolar( double dolar )
        {
            if ( dolar <= 0 )
            {
                this.dolar = 24.71;
            } else
            {
                this.dolar = dolar;
            }
        }
    }
}
