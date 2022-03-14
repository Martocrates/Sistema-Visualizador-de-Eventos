using System;

namespace VisualizadorEventosSistema
{
    public class RecuperadorEventos : IDatos_Evento
    {

        ProcesadorDatos evento;
   

        public RecuperadorEventos(ProcesadorDatos evento)
        {
            this.evento = evento;
           
        }
   
        public void recuperadorFecha(string fechaEvento)
        {
            DateTime dateTimeEvento = DateTime.Parse(fechaEvento);
            evento.procesadorFecha(dateTimeEvento, getFechaActual());

        }
        public void recuperadorEvento(string tituloEvento)
        {
           
            evento.procesadorEvento(tituloEvento);
            //return tituloEvento;
        }
        public DateTime getFechaActual()
        {
            DateTime miFecha = DateTime.Now;
            return miFecha;
        }
    }
}