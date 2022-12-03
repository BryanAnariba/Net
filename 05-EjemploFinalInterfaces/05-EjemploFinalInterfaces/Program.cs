namespace _05_EjemploFinalInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico avt = new AvisosTrafico();
            avt.mostrarAviso();
            AvisosTrafico avt1 = new AvisosTrafico( "Jefatura De Honduras", "Multa por Exceso de velocidad 500 Lps", "02/05/2019" );
            avt1.mostrarAviso();
        }
    }
}
