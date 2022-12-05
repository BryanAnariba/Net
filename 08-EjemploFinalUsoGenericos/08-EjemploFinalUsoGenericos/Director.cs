using System;

namespace _08_EjemploFinalUsoGenericos
{
    internal class Director: IEmpleados
    {
        private double salario;
        public Director(double salario) {
            this.salario = salario;
        }

        public double getSalario ()
        {
            return this.salario;
        }
    }
}
