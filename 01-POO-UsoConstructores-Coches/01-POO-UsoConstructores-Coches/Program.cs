using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_POO_UsoConstructores_Coches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche honda = new Coche( 4, 3.25, 1.6, true, "Cuero" );
            Console.WriteLine($"Datos del coche: { honda.toString() }");
            Coche susuki = new Coche();
            Console.WriteLine($"Datos del coche: { susuki.toString() }");
        }
    }

    class Coche {
        private int cantidadRuedas;
        private double largoCoche;
        private double anchoCoche;
        private bool tieneClimatizador;
        private String tipoTapiceria;

        // CONSTRUCTOR Y SOBRECARGA
        public Coche ()
        {
            // SI SE HACE UNA INSTANCIA DE ESTO SIGNIFICA QUE EL COCHE SERA GENERICO
            this.cantidadRuedas = 4;
            this.largoCoche = 3;
            this.anchoCoche = 1.5;
            this.tieneClimatizador = false;
            this.tipoTapiceria = "Tela";
        }
        public Coche ( int cantidadRuedas, double largoCoche, double anchoCoche, bool tieneClimatizador, String tipoTapiceria )
        {
            // SI SE HACE UNA INSTANCIA DE ESTO SIGNIFICA QUE EL COCHE SERA PERSONALIZADO
            this.cantidadRuedas = cantidadRuedas;
            this.largoCoche = largoCoche;   
            this.anchoCoche = anchoCoche;
            this.tieneClimatizador = tieneClimatizador;
            this.tipoTapiceria = tipoTapiceria;
        }

        // SETTERS
        public void setCantidadRuedas ( int cantidadRuedas )
        {
            this.cantidadRuedas = cantidadRuedas;
        }
        public void setLargoCoche( double largoCoche )
        {
            this.largoCoche = largoCoche;
        }
        public void setAnchoCoche( double anchoCoche )
        {
            this.anchoCoche = anchoCoche;   
        }
        public void setTieneClimatizador( bool tieneClimatizador )
        {
            this.tieneClimatizador = tieneClimatizador;
        }
        public void setTipoTapiceria( String tipoTapiceria )
        {
            this.tipoTapiceria = tipoTapiceria;
        }

        // GETTERS
        public int getCantidadRuedas ()
        {
            return this.cantidadRuedas;
        }
        public double getAnchoCoche ()
        {
            return this.anchoCoche;
        }
        public double getLargoCoche ()
        {
            return this.largoCoche;
        }
        public bool getTieneClimatizador ()
        {
            return this.tieneClimatizador;
        }
        public String getTipoTapiceria ()
        {
            return this.tipoTapiceria;
        }

        public String toString ()
        {
            return (
                "{ " + 
                "cantidadRuedas: " + this.cantidadRuedas +
                ", largoCoche: " + this.largoCoche + 
                ", anchoCoche: " + this.anchoCoche + 
                ", tieneClimatizador: " + this.tieneClimatizador + 
                ", tipoTapiceria: " + this.tipoTapiceria + 
                " }"
            );
        }

    }
}
