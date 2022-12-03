using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_POOConceptosHerencia
{
    internal class Humano: Mamifero, IMamiferoTerrestres, IAnimalesUsadosEnDeportes
    {
        public Humano() { }

        public Humano( String tipoSerVivo ): base( tipoSerVivo ) {
            
        }
        
        override
        public void pensar ()
        {
            //cuidarCrias();
            Console.WriteLine("Soy humano y soy un ser pensante avanzado supuestamente");
        }

        public int cantidadPatas()
        {
            return 2;
        }

        public string tipoDeporte()
        {
            return "ATLETISMO";
        }

        public Boolean esDeporteOlimpico()
        {
            return true;
        }
    }
}
