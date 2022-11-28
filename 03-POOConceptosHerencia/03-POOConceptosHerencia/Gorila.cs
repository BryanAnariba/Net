using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_POOConceptosHerencia
{
    internal class Gorila: Mamifero
    {
        public Gorila() { }

        public Gorila( String tipoSerVivo ): base( tipoSerVivo ) { 
            
        }
        public void treparArboles ()
        {
            Console.WriteLine("Soy gorila y trepo palos y palos");
        }

        override
        public void pensar ()
        {
            Console.WriteLine("Pienso como Mono Osea Primitivamente");
        }
    }
}
