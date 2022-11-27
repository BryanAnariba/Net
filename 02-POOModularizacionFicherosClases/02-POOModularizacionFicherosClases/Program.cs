using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_POOModularizacionFicherosClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.realizaTarea();
            Punto parte1 = new Punto( -1, 5 );
            Punto parte2 = new Punto( 2, -4 );
            Console.WriteLine( "Distancia: " + parte1.getDistanciaEntrePuntos( parte2 ) );
            Punto.getCantidadInstanciasCreadas();
        }

        static void realizaTarea ()
        {
            //Punto miPunto = new Punto( 5.75, 6.00 );
        }

        static void realizaTarea2()
        {
            // TODO: 
        }
    }
}
