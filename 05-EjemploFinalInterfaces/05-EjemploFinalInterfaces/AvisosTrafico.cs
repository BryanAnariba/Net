using System;

namespace _05_EjemploFinalInterfaces
{
    internal class AvisosTrafico : IAviso
    {
        private string remitente;
        private string mensaje;
        private string fecha;

        public AvisosTrafico ()
        {
            this.remitente = "DGT";
            this.mensaje = "Sancion Cometida: PAGUE ANTES DE TRES DIAS";
            this.fecha = "";
        }

        public AvisosTrafico( string remitente, string mensaje, string fecha )
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public void setRemitente ( string remitente )
        {
            this.remitente = remitente;
        }

        public void setMensaje ( string mensaje )
        {
            this.mensaje = mensaje;
        }

        public void setFecha ( string fecha )
        {
            this.fecha = fecha;
        }

        public string getRemitente ()
        {
            return this.remitente;
        }

        public string getMensaje ()
        {
            return this.mensaje;
        }

        public string getFecha()
        {
            return this.fecha;
        }
        public string getFechaAviso()
        {
            return this.fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine($"Mensaje {this.mensaje}, ha sido enviado por {this.remitente} a la fecha {this.fecha}");
        }
    }
}
