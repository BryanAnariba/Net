using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_POOPracticaTodo
{
    internal class Avion: Vehiculo
    {
        private String sonido;
        public Avion ()
        {

        }

        public Avion ( String tipoVehiculo, String sonido ): base( tipoVehiculo )
        {
            this.sonido = sonido;
        }

        override
        public void conduciendo()
        {
            Console.WriteLine($"Estoy manejando un avion: { this.sonido }");
        }

        public void despegar ()
        {
            Console.WriteLine("Despegando");
        }

        public void aterrizar ()
        {
            Console.WriteLine("Aterrizando");
        }
    }
}
