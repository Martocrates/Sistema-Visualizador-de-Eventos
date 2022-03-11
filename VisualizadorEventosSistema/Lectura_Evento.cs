using System;

namespace VisualizadorEventosSistema
{
    public class Lectura_Evento : Datos_Evento
    {

        CalculaTiempo miTiempoEvento;

        public Lectura_Evento(CalculaTiempo miTiempoEvento)
        {
            this.miTiempoEvento = miTiempoEvento;
        }
   
        public void lecturaFechaEvento(string fechaEvento)
        {
            DateTime dateTimeActual = getFechaActual();
            DateTime dateTimeEvento = DateTime.Parse(fechaEvento);

            int diferenciaMeses = dateTimeEvento.Month - dateTimeActual.Month;
            int diferenciaDias = dateTimeEvento.Day - dateTimeActual.Day;
            int diferenciaHoras = dateTimeEvento.Hour - dateTimeActual.Hour;
            int diferenciaMinutos = dateTimeEvento.Minute - dateTimeActual.Minute;

            miTiempoEvento.setDiferenciaHoraria(diferenciaMeses, diferenciaDias, diferenciaHoras, diferenciaMinutos);
        }
        public void lecturaTituloEvento(string tituloEvento)
        {
            Console.Write(tituloEvento+"");
            //return tituloEvento;
        }
        public DateTime getFechaActual()
        {
            DateTime miFecha = DateTime.Now;
            return miFecha;
        }
    }
}