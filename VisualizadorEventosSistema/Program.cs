using System;

namespace VisualizadorEventosSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaTiempo miTiempoEvento = new CalculaTiempo();
            Lectura_ArchivoTXT miArchivoEventos = new Lectura_ArchivoTXT();
            Lectura_Evento informacionEvento = new Lectura_Evento(miTiempoEvento);

            miArchivoEventos.lecturaArchivo("eventos");
                       
            SeparadorFechasEventos informacionMiEvento = new SeparadorFechasEventos(miArchivoEventos,informacionEvento);
            informacionMiEvento.BuscaFechasEventos();

            Console.ReadLine();
        }
    }
}
