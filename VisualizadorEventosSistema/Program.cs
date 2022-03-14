using System;

namespace VisualizadorEventosSistema
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string nombreArchivo="eventos";
            string extensionArchivo =".txt";

            LecturaArchivo recuperador = new LecturaArchivo(nombreArchivo, extensionArchivo);
            ImpresionConsola visualizadorConsola = new ImpresionConsola();
            ProcesadorDatos procesadorTiempo = new ProcesadorDatos(visualizadorConsola);
            RecuperadorEventos procesadorEvento = new RecuperadorEventos(procesadorTiempo);
            AppEventos application = new AppEventos(recuperador,procesadorEvento);


            application.start();
           
            Console.ReadLine();
        }
    }
}
