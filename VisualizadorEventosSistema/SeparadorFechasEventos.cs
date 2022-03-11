using System;
using System.Text.RegularExpressions;

namespace VisualizadorEventosSistema
{
    public class SeparadorFechasEventos
    {
        Lectura_ArchivoTXT miArchivoEventos;
        Lectura_Evento informacionEvento;
        string tituloEvento;
        string fechaEvento;
        int comienzoBusquedaFecha;
        private int comienzoBusquedaTitulo = 0;
        public SeparadorFechasEventos(Lectura_ArchivoTXT miArchivoEventos, Lectura_Evento informacionEvento)
        {
            this.miArchivoEventos = miArchivoEventos;
            this.informacionEvento = informacionEvento;

            BuscaFechasEventos();
        }
        private void BuscaFechasEventos()
        {
           
            foreach (object misEventosConFecha in miArchivoEventos.getArrayListLineasArchivoTXT())
            {
                                                    
                if (elFormatoEsCorrecto(misEventosConFecha))
                {
                    tituloEvento = misEventosConFecha.ToString().Substring(comienzoBusquedaTitulo, comienzoBusquedaFecha);
                    fechaEvento = misEventosConFecha.ToString().Substring(comienzoBusquedaFecha + 2);

                    informacionEvento.lecturaTituloEvento(tituloEvento);
                    informacionEvento.lecturaFechaEvento(fechaEvento);
                }

            }

        }
        private Boolean elFormatoEsCorrecto(object misEventosConFecha)
        {
            comienzoBusquedaFecha = misEventosConFecha.ToString().IndexOf(",");

           if( comienzoBusquedaFecha > comienzoBusquedaTitulo) //Basicamente si la fecha esta despues del titulo separado de una ,
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

    }
}