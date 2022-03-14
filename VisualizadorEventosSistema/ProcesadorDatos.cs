using System;
namespace VisualizadorEventosSistema
{
    public class ProcesadorDatos
    {
        int diferenciaMeses;
        int diferenciaDias;
        int diferenciaHoras;
        int diferenciaMinutos;
        int tiempoActualFaltanteParaTiempoActual = 0;

        string meses = " meses";
        string dias = " dias";
        string horas = " horas";
        string minutos = " minutos";

        ImpresionConsola impresionConsola;

        public ProcesadorDatos(ImpresionConsola impresionConsola)
        {
            this.impresionConsola = impresionConsola;
        }


        public void procesadorFecha(DateTime fechaEvento, DateTime fechaActual)
        {

            diferenciaMeses = fechaEvento.Month - fechaActual.Month;
            diferenciaDias = fechaEvento.Day - fechaActual.Day;
            diferenciaHoras = fechaEvento.Hour - fechaActual.Hour;
            diferenciaMinutos = fechaEvento.Minute - fechaActual.Minute;
            CalculaTiempoConcurridoEnEventos();
            
        }

        public void procesadorEvento(string evento)
        {
            impresionConsola.DesplegarEvento(evento);
        }
      

        private void CalculaMeses()
        {
            if (diferenciaMeses > tiempoActualFaltanteParaTiempoActual)
            {
                impresionConsola.DesplegarOcurrira(diferenciaMeses, meses);
            }
            if (diferenciaMeses < tiempoActualFaltanteParaTiempoActual)
            {
                impresionConsola.DesplegarOcurrio(diferenciaMeses, meses);
              
            }
        }

        private void CalculaDias()
        {
            if (diferenciaMeses == tiempoActualFaltanteParaTiempoActual)
            {
                if (diferenciaDias > tiempoActualFaltanteParaTiempoActual)
                {

                    impresionConsola.DesplegarOcurrira(diferenciaDias, dias);
                }
                if (diferenciaDias < tiempoActualFaltanteParaTiempoActual)
                {
            
                    impresionConsola.DesplegarOcurrio(diferenciaDias, dias);
                }

            }
        }

        private void CalculaHoras()
        {
            if (diferenciaDias == tiempoActualFaltanteParaTiempoActual && diferenciaMeses == tiempoActualFaltanteParaTiempoActual)
            {
                if (diferenciaHoras > tiempoActualFaltanteParaTiempoActual)
                {            
                    impresionConsola.DesplegarOcurrira(diferenciaHoras, horas);
                }
                if (diferenciaHoras < tiempoActualFaltanteParaTiempoActual)
                {
                    impresionConsola.DesplegarOcurrio(diferenciaHoras, horas);
                
                }

            }

        }

        private void CalculaMinutos()
        {
            if (diferenciaDias == tiempoActualFaltanteParaTiempoActual && diferenciaMeses == tiempoActualFaltanteParaTiempoActual)
            {

                if (diferenciaHoras == tiempoActualFaltanteParaTiempoActual)
                {
                    if (diferenciaMinutos > tiempoActualFaltanteParaTiempoActual)
                    {
                    
                        impresionConsola.DesplegarOcurrira(diferenciaMinutos, minutos);
                    }
                    if (diferenciaMinutos < tiempoActualFaltanteParaTiempoActual)
                    {
                        impresionConsola.DesplegarOcurrio(diferenciaMinutos, minutos);
                       
                    }
                }
            }


        }
        private void CalculaTiempoConcurridoEnEventos()
        {
            //Calcula tiempo
            CalculaMeses();
            CalculaDias();

            CalculaHoras();
            CalculaMinutos();

        }

    }
}