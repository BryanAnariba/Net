using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Colecciones_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumerosEnteros = new List<int>();
            // AGREGAR ELEMENTOS
            listaNumerosEnteros.Add(111);
            listaNumerosEnteros.Add(222);
            listaNumerosEnteros.Add(333);
            listaNumerosEnteros.Add(444);
            listaNumerosEnteros.Add(555);
            
            for ( int i=0; i<listaNumerosEnteros.Count(); i++ )
            {
                Console.WriteLine(listaNumerosEnteros[i]);
            }

            /*
            List<int> numeros = new List<int>();
            Console.WriteLine("Cuantos elementos quieres en el arreglo: ");
            int tamanio = Int32.Parse(Console.ReadLine());  
            for ( int i=0; i<tamanio; i++ )
            {
                Console.WriteLine($"Digite el {i} numero: ");
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine("");
            Console.WriteLine("ELEMENTOS");
            for ( int i=0; i<numeros.Count(); i++ )
            {
                Console.WriteLine(numeros[i]);
            }
            */
            Console.WriteLine("Digita un numero ( 0 para salir )");
            int elemento = 1;
            List<int> coleccionNumeros = new List<int>();
            while ( elemento != 0 )
            {
                elemento = int.Parse(Console.ReadLine());   
                coleccionNumeros.Add(elemento);
                Console.WriteLine("Digita un numero ( 0 para salir )");
            }
            coleccionNumeros.RemoveAt( coleccionNumeros.Count() - 1 );
            Console.WriteLine("Elementos introducidos");
            foreach( int numero in coleccionNumeros )
            {
                Console.WriteLine($"Numero {numero}");
            }
        }
    }
}
