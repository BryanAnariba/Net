using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_POOPracticaTodo
{
    internal class Coche: Vehiculo
    {
        private String sonido;
        public Coche ()
        {

        }

        public Coche( String tipoVehiculo, String sonido ): base( tipoVehiculo )
        {
            this.sonido = sonido;
        }

        override
        public void conduciendo ()
        {
            Console.WriteLine($"Estoy Conduciendo un Carro: { this.sonido }");
        }

        public void frenar()
        {
            Console.WriteLine("Frenando");
        }

        public void acelerando ()
        {
            Console.WriteLine("Acelerando");
        }
    }
}
