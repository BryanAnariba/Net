using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_POOPracticaTodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo[] vehiculos = new Vehiculo[2];
            vehiculos[0] = new Coche("Honda Civic", "RUUUUUUUUUM");
            vehiculos[1] = new Avion("Boing 747", "TURBINA");

            for ( int i = 0; i < vehiculos.Length; i++ )
            {
                vehiculos[i].conduciendo();
            }
        }
    }
}
