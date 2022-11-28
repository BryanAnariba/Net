using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_POOPracticaTodo
{
    internal class Vehiculo
    {
        private String tipoVehiculo;
        public Vehiculo() { }

        public Vehiculo ( String tipoVehiculo )
        {
            this.tipoVehiculo = tipoVehiculo;
        }
        public void arrancarVehiculo ()
        {
            Console.WriteLine("En Sus Marcas Listos Fuera.....");
        }

        public void frenarVehiculo ()
        {
            Console.WriteLine("Disminuyendo Velocidad");
        }

        public virtual void conduciendo ()
        {
            Console.WriteLine("Estoy conduciendo el vehiculo");
        }

        public void setTipoVehiculo ( String tipoVehiculo )
        {
            this.tipoVehiculo = tipoVehiculo;
        }

        public String getTipoVehiculo ()
        {
            return this.tipoVehiculo;
        }
    }
}
