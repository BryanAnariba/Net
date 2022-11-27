using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_POOModularizacionFicherosClases
{
    // CLASE CREADA AL DAR CLICK EN: Provecto/Agregar Clase
    internal class Punto
    {
        private static int instanciasCreadas = 0;
        private double coordenadaX;
        private double coordenadaY;

        // CONSTRUCTORES
        public Punto ()
        {
            this.coordenadaX = 0;
            this.coordenadaY = 0;
            Punto.instanciasCreadas += 1;
        }
        public Punto( double coordenadaX, double coordenadaY ) {
            this.coordenadaX = coordenadaX;
            this.coordenadaY = coordenadaY;
            Punto.instanciasCreadas += 1;
            Console.WriteLine( $"Datos Generados Por El Constructor, Coord X: {  this.coordenadaX }, Coord Y: { this.coordenadaY }" );
        }  


        // SETTERS
        public void setCoordenadaX ( double coordenadaX )
        {
            this.coordenadaX = coordenadaX;
        }
        public void setCoordenadaY ( double coordenadaY )
        {
            this.coordenadaY = coordenadaY; 
        }

        // GETTERS
        public double getCoordenadaX()
        {
            return this.coordenadaX;
        }
        public double getCoordenadaY()
        {
            return this.coordenadaY;    
        }

        // METODOS OTROS
        public double getDistanciaEntrePuntos( Punto otroPunto ) {
            // FORMULA DISTANCIA ENTRE DOS PUNTOS =  RAIZ DE (( x2-x1 )CUADRADO + ( Y2 - Y1 )CUADRADO )
            double parte1 = Math.Pow( ( otroPunto.getCoordenadaX() - this.coordenadaX ), 2 );
            double parte2 = Math.Pow( ( otroPunto.getCoordenadaY() - this.coordenadaY ), 2 );
            double distanciaEntreDosPuntos = Math.Sqrt(parte1 + parte2);
            return distanciaEntreDosPuntos;
        }

        public static void getCantidadInstanciasCreadas ()
        {
            Console.WriteLine("Instancias de Punto Creadas: " + Punto.instanciasCreadas);
        }
    }
}
