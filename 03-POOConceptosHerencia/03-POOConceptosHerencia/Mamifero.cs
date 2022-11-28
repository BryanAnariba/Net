using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_POOConceptosHerencia
{
    internal class Mamifero
    {
        private String tipoSerVivo;

        public Mamifero()
        {

        }

        public Mamifero( String tipoSerVivo )
        {
            this.tipoSerVivo = tipoSerVivo;
        }
        public void respirar ()
        {
            Console.WriteLine("Soy Capaz de Respirar");
        }

        protected void cuidarCrias ()
        {
            Console.WriteLine("Cuido de mis crias hasta que se puedan valer solas");
        }

        // con esto de virtual decimos que todas las subclases de mamiferos deben tener un metodo pensar propio que modifique este, eso si debemos poner override en las subclases
        public virtual void pensar ()
        {
            Console.WriteLine("Este ser vivo piensa");
        }
        public String getTipoSerVivo()
        {
            return this.tipoSerVivo;
        }
    }
}
