using System;

namespace _08_EjemploFinalUsoGenericos
{
    internal class Secretaria : IEmpleados
    {
        private double salario;
        public Secretaria(double salario) {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }
    }
}
