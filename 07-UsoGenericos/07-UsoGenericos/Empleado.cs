using System;

namespace _07_UsoGenericos
{
    internal class Empleado
    {
        private double salarioEmpleado;
        public Empleado(double salarioEmpleado)
        {
            this.salarioEmpleado = salarioEmpleado;
        }

        public double getSalarioEmpleado()
        {
            return this.salarioEmpleado;
        }
    }
}
