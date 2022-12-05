using System;

namespace _07_UsoGenericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<String> nombres = new AlmacenObjetos<String>(10);
            nombres.addElement("Bryan Ariel Sanchez Anariba");
            nombres.addElement("Maria Fernanda Sanchez Anariba");
            nombres.addElement("Erick David Jimenez Anariba");
            nombres.addElement("Silvia Romero");

            // OJO A ESTO SIN EL CASTING NO ES POSIBLE ALMACENAR EN SEGUNDO NOMBRE PARA ESTO SE USAN LOS GENERICOS
            String segundoNombre = nombres.getElement(2);
            Console.WriteLine($"Posicion 2: {segundoNombre}");

            AlmacenObjetos<Empleado> empleados = new AlmacenObjetos<Empleado>(3);
            empleados.addElement(new Empleado(1500));
            empleados.addElement(new Empleado(2500));
            empleados.addElement(new Empleado(3500));
            Empleado salarioEmpleado = empleados.getElement(2);
            Console.WriteLine("Salario del segundo empleado: " + salarioEmpleado.getSalarioEmpleado());

            AlmacenObjetos<DateTime> fechas = new AlmacenObjetos<DateTime>(3);
            fechas.addElement(new DateTime());
            fechas.addElement(new DateTime());
            fechas.addElement(new DateTime());
            DateTime fechaDos = fechas.getElement(2);
            Console.WriteLine($"Fecha Segundo Item: ${fechaDos}");


        }
    }
}
