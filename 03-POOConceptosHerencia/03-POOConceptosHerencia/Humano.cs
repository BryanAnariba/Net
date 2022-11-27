using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_POOConceptosHerencia
{
    internal class Humano: Mamifero 
    {
        public Humano() { }

        public Humano( String tipoSerVivo ): base( tipoSerVivo ) { 
        }
        
        override
        public void pensar ()
        {
            Console.WriteLine("Soy humano y soy un ser pensante avanzado supuestamente");
        }
    }
}
