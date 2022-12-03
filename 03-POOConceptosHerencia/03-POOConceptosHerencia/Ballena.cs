using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_POOConceptosHerencia
{
    internal class Ballena: Mamifero
    {
        public Ballena ( string tipoSerVivo ): base ( tipoSerVivo )
        {
            
        }

        public void nadar()
        {
            Console.WriteLine("Soy una ballena y nado a las profundidades por horas");
        }
    }
}
