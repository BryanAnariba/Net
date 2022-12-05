using System;

namespace _07_UsoGenericos
{
    internal class AlmacenObjetos<T>
    {
        private int tamanioArreglo;
        private int i;
        private T [] elementos;
        public AlmacenObjetos ( int tamanioArreglo )
        {
            this.tamanioArreglo = tamanioArreglo;
            this.elementos = new T[ tamanioArreglo ];
        }

        public void addElement ( T obj ) {
            this.elementos[this.i] = obj;
            this.i += 1;
        }

        public T getElement ( int i )
        {
            return this.elementos[i];
        }
    }
}
