using System;
using System.Collections.Generic;

namespace _11_ColeccionesFIFO_Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> colaDeNumerosEnteros = new Queue<int>();
            foreach( int numero in new int[] { 111, 222, 333, 444, 555 } )
            {
                colaDeNumerosEnteros.Enqueue(numero); // agregando numero
            }
        
            foreach ( int numero in colaDeNumerosEnteros)
            {
                Console.WriteLine("Numero en cola: " + numero);
            }

            Console.WriteLine("Eliminando un elemento primero en entrar en este caso es 111 y es el primero en salir");
            colaDeNumerosEnteros.Dequeue();
            foreach (int numero in colaDeNumerosEnteros)
            {
                Console.WriteLine("Numero en cola: " + numero);
            }
        }
    }
}
