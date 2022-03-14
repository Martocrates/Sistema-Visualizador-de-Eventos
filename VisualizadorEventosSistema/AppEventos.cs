using System;
using System.Text.RegularExpressions;

namespace VisualizadorEventosSistema
{
    public class AppEventos
    {
        LecturaArchivo ListaEvento;
        RecuperadorEventos informacionEvento;
        string tituloEvento;
        string fechaEvento;
        int comienzoBusquedaFecha;
        private int comienzoBusquedaTitulo = 0;
        public AppEventos(LecturaArchivo miArchivoEventos, RecuperadorEventos informacionEvento)
        {
            ListaEvento = miArchivoEventos;
            this.informacionEvento = informacionEvento;
        }
        private void BuscaFechasEventos()
        {
            foreach (object Evento in ListaEvento.getListaEvento())
            {                                    
                if (elFormatoEsCorrecto(Evento))
                {
                    tituloEvento = Evento.ToString().Substring(comienzoBusquedaTitulo, comienzoBusquedaFecha);
                    fechaEvento = Evento.ToString().Substring(comienzoBusquedaFecha + 2);

                    informacionEvento.recuperadorEvento(tituloEvento);
                    informacionEvento.recuperadorFecha(fechaEvento);
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
        public void start()
        {
            BuscaFechasEventos();
        }
    }
}