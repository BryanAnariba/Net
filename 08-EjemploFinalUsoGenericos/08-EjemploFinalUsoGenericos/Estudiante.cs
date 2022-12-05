using System;

namespace _08_EjemploFinalUsoGenericos
{
    internal class Estudiante
    {
        private double edadEstudiante;
        public Estudiante ( double edadEstudiante )
        {
            this.edadEstudiante = edadEstudiante;
        }

        public double getEdadEstudiante ()
        {
            return this.edadEstudiante;
        }
    }
}
