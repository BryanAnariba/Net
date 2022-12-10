using System;
using System.Collections.Generic;
namespace _10_Colecciones_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numerosEnteros = new LinkedList<int>();
            foreach( int numeroEntero in new int[] { 1,2,3,4,5,6,7,8,9,10 } )
            {
                numerosEnteros.AddFirst(numeroEntero);
            }

            foreach( int numeroEntero in numerosEnteros)
            {
                Console.WriteLine($"Numero: { numeroEntero }");
            }

            for (LinkedListNode<int> nodo=numerosEnteros.First; nodo != null; nodo = nodo.Next )
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }
        }
    }
}
