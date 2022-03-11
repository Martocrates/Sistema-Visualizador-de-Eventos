using System;

namespace VisualizadorEventosSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaTiempo miTiempoEvento = new CalculaTiempo();
            Lectura_ArchivoTXT miArchivoEventos = new Lectura_ArchivoTXT("eventos", ".txt");
            Lectura_Evento informacionEvento = new Lectura_Evento(miTiempoEvento);
            SeparadorFechasEventos informacionMiEvento = new SeparadorFechasEventos(miArchivoEventos,informacionEvento);
            

            Console.ReadLine();
        }
    }
}
