using System;

namespace _08_EjemploFinalUsoGenericos
{
    internal class Electricista: IEmpleados
    {
        private double salario;
        public Electricista(double salario) {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }
    }
}
