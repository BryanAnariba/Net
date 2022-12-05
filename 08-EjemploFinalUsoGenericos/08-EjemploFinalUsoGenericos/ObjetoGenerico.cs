using System;

namespace _08_EjemploFinalUsoGenericos
{
    // OJO AQUI ESTAS CONDICIONANDO CON EL WHERE QUE SOLO PERMITA OBJETOS GENERICOS QUE TENGAN SALARIO
    internal class ObjetoGenerico<T> where T: IEmpleados
    {
        private int cantidadObjetos = 0;
        private T[] ObjetosX;
        private int contadorObjetos = 0;

        public ObjetoGenerico ( int cantidadObjetos )
        {
            this.cantidadObjetos = cantidadObjetos;
            this.ObjetosX = new T[this.cantidadObjetos];
        }

        public void addObjetoGenerico ( T objecto )
        {
            this.ObjetosX[ this.contadorObjetos ] = objecto;
            this.contadorObjetos += 1;
        }

        public T getObjeto ( int posicionObjeto )
        {
            return this.ObjetosX[ posicionObjeto ]; 
        }
    }
}
