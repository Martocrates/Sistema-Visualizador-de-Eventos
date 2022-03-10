using System;
using System.Text.RegularExpressions;

namespace VisualizadorEventosSistema
{
    public class SeparadorFechasEventos
    { 
        Lectura_ArchivoTXT miArchivoEventos ;
        Lectura_Evento informacionEvento ;
        
        string patronRGXEvento = @"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+";
        string patronRGXFecha = @"([0-2][0-9]|3[0-1])(\/)(0[1-9]|1[0-2])\2(\d{4})(\s)([0-1][0-9]|2[0-3])(:)([0-5][0-9])$|([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$";
        string patronRGXEventoMasFecha = @"([a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+,) ([0-2][0-9]|3[0-1])(\/)(0[1-9]|1[0-2])(\/)([0-9]{4})";

        public SeparadorFechasEventos(Lectura_ArchivoTXT miArchivoEventos, Lectura_Evento informacionEvento)
        {
            this.miArchivoEventos = miArchivoEventos;
            this.informacionEvento = informacionEvento;
        }

        public void BuscaFechasEventos()
        {
            Regex rgxEvento = new Regex(patronRGXEvento);
            Regex rgxFecha = new Regex(patronRGXFecha);

            Match matchEvento;
            Match matchFecha;
            foreach (object misEventosConFecha in miArchivoEventos.getArrayListLineasArchivoTXT())
            {
                matchEvento = rgxEvento.Match(misEventosConFecha.ToString());
                matchFecha = rgxFecha.Match(misEventosConFecha.ToString());

                //Valida si el formato es correcto [EVENTO , DD/MM/YYYY HH:MM]
                if (elFormatoEsCorrecto(misEventosConFecha))
                {
                    //Si es un evento
                    if (rgxEvento.IsMatch(misEventosConFecha.ToString()))
                    {
                        informacionEvento.lecturaTituloEvento(matchEvento.Groups[0] + "");
                    }
                    //Si es una fecha
                    if (rgxFecha.IsMatch(misEventosConFecha.ToString()))
                    {
                        informacionEvento.lecturaFechaEvento(matchFecha.Groups[0] + "");
                    }
                }
             
            }
        }
        private Boolean elFormatoEsCorrecto(object misEventosConFecha)
        {
            Regex rgxEventoMasFecha = new Regex(patronRGXEventoMasFecha);
            
           return rgxEventoMasFecha.IsMatch(misEventosConFecha.ToString());
        }

    }
}