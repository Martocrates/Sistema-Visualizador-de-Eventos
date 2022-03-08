using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace VisualizadorEventosSistema
{
    public class SeparadorFechasEventos
    {
        Lectura_ArchivoTXT miArchivoEventos = new Lectura_ArchivoTXT();
        Lectura_Evento informacionEvento = new Lectura_Evento();
        
        string patronRGXEvento = @"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+";
        string patronRGXFecha = @"([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})(\s)([0-1][0-9]|2[0-3])(:)([0-5][0-9])$|([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$";
     
        public void BuscaFechasEventos()
        {
            Regex rgxEvento = new Regex(patronRGXEvento);
            Regex rgxFecha = new Regex(patronRGXFecha);

            Match matchEvento;
            Match matchFecha;

            foreach (object o in miArchivoEventos.getArrayListLineasArchivoTXT())
            {
                matchEvento = rgxEvento.Match(o.ToString());
                matchFecha = rgxFecha.Match(o.ToString());

                //Console.WriteLine(o.ToString() + " ");

                if (rgxEvento.IsMatch(o.ToString()))
                {
                  //  Console.WriteLine("Es evento: " + matchEvento.Groups[0]);
                    informacionEvento.lecturaTituloEvento(matchEvento.Groups[0]+"");
                }

                if (rgxFecha.IsMatch(o.ToString()))
                {
                    //  Console.WriteLine("Es fecha: "+ matchFecha.Groups[0]);
                    informacionEvento.lecturaFechaEvento(matchFecha.Groups[0] + "");
                }


            }

        }
    }
}