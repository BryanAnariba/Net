using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_POOConceptosHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano bryan = new Humano("Latino");
            Console.WriteLine($"Tipo Ser Vivo: {bryan.getTipoSerVivo()}");
            bryan.pensar();
            Gorila chimpance = new Gorila("Chimpanse");
            Console.WriteLine($"Tipo Ser Vivo: {chimpance.getTipoSerVivo()}");
            chimpance.treparArboles();
            chimpance.pensar();
            Caballo puraSangre = new Caballo("Caballo Pura Sangre");
            Console.WriteLine($"Tipo Ser Vivo: {puraSangre.getTipoSerVivo()}");
            puraSangre.galopar();
            puraSangre.pensar();
            Console.WriteLine(puraSangre.cantidadPatas()); ;
            Console.WriteLine(puraSangre.esDeporteOlimpico());
            Console.WriteLine(puraSangre.saltoConNumeroPatas(2));
     

            Ballena orca = new Ballena("Orca");
            orca.pensar();
        }
    }
}
