using System;

namespace _08_EjemploFinalUsoGenericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SI OBSERVAN VERAN QUE GENERA OBJETOS GENERICOS DE CLASES QUE TIENEN EL METODO DE OBTENER SALARIO
            ObjetoGenerico<Director> directores = new ObjetoGenerico<Director>(3);
            directores.addObjetoGenerico(new Director(1000));
            directores.addObjetoGenerico(new Director(2000));
            directores.addObjetoGenerico(new Director(3000));

            ObjetoGenerico<Secretaria> secretarias = new ObjetoGenerico<Secretaria>(3);
            secretarias.addObjetoGenerico(new Secretaria(1000));
            secretarias.addObjetoGenerico(new Secretaria(2000));
            secretarias.addObjetoGenerico(new Secretaria(3000));


            ObjetoGenerico<Electricista> electricistas = new ObjetoGenerico<Electricista>(3);
            electricistas.addObjetoGenerico(new Electricista(1000));
            electricistas.addObjetoGenerico(new Electricista(2000));
            electricistas.addObjetoGenerico(new Electricista(3000));


            // PERO EN EL CASO DE NO TENER ESTA INTERFAZ QUE REQUIERE DICHO METODO, OBSERVEN EN ESTE CASO CON LA CLASE ESTUDIANTE QUE UN ESTUDIANTE NO DEBE TENER SALARIO
            // AQUI DA ERROR
            /*
            ObjetoGenerico<Estudiante> estudiantes = new ObjetoGenerico<Estudiante>(3);
            estudiantes.addObjetoGenerico(new Estudiante(1000));
            estudiantes.addObjetoGenerico(new Estudiante(2000));
            estudiantes.addObjetoGenerico(new Estudiante(3000));
            */
        }
    }
}
