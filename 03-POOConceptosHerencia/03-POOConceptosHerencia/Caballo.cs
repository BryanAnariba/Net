using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_POOConceptosHerencia
{
    internal class Caballo: Mamifero, IMamiferoTerrestres, IAnimalesUsadosEnDeportes, ISaltoConXPatas
    {
        public Caballo() { }
        public Caballo( String tipoSerVivo ): base( tipoSerVivo ) {
            
        }
        
        public void galopar ()
        {
            Console.WriteLine("Soy caballo y galopo");
        }

        override
        public void pensar ()
        {
            Console.WriteLine("Pienso primitivamente como caballo");
        }

        public int cantidadPatas ()
        {
            return 4;
        }

        public string tipoDeporte()
        {
            return "Cabalgata Cantando";
        }

        public Boolean esDeporteOlimpico()
        {
            return false;
        }

        public int saltoConNumeroPatas(int cantidadPatas)
        {
            return cantidadPatas;
        }
    }
}
