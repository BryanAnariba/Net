using System;

namespace _06_Enum_y_Struct
{
    internal class Empleado
    {
        private double salario;
        private double bonoEmpleado;

        public Empleado( double salario, Bono bonoEmpleado ) {
            this.salario = salario;
            this.bonoEmpleado = (double)bonoEmpleado;
        }

        public double getSalarioConBono ()
        {
            return Math.Round( this.salario + this.bonoEmpleado, 4 );
        }
    }
}
