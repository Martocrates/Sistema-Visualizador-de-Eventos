using System;
namespace VisualizadorEventosSistema
{
    public class CalculaTiempo
    {
        int diferenciaMeses;
        int diferenciaDias;
        int diferenciaHoras ;
        int diferenciaMinutos;
        int tiempoActualFaltanteParaTiempoActual = 0;
        public void setDiferenciaHoraria(int diferenciaMeses, int diferenciaDias,
                                        int diferenciaHoras, int diferenciaMinutos)
        {
            this.diferenciaMeses = diferenciaMeses;
            this.diferenciaDias = diferenciaDias;
            this.diferenciaHoras = diferenciaHoras;
            this.diferenciaMinutos = diferenciaMinutos;
        }

        private void CalculaMeses()
        {
            if (diferenciaMeses > tiempoActualFaltanteParaTiempoActual) {
                Console.WriteLine(" Ocurrira en " + diferenciaMeses + " meses");
            }
            if (diferenciaMeses < tiempoActualFaltanteParaTiempoActual)
            {
                Console.WriteLine(" Ocurrio hace " + diferenciaMeses *-1 + " meses");
            }
        }

        private void CalculaDias()
        {
            if (diferenciaMeses == tiempoActualFaltanteParaTiempoActual)
            {
                if (diferenciaDias > tiempoActualFaltanteParaTiempoActual)
                {
                    Console.WriteLine(" Ocurrira en " + diferenciaDias + " dias");
                }
                if (diferenciaDias < tiempoActualFaltanteParaTiempoActual)
                {
                    Console.WriteLine(" Ocurrio hace " + diferenciaDias * -1 + " dias");
                }

            }
        }

        private void CalculaHoras()
        {
            if(diferenciaHoras > tiempoActualFaltanteParaTiempoActual)
            {
                Console.WriteLine(" Ocurrira en " + diferenciaHoras + " horas");
            }
            if (diferenciaHoras < tiempoActualFaltanteParaTiempoActual)
            {
                Console.WriteLine(" Ocurrio hace " + diferenciaHoras * -1 + " horas");
            }
        }

        private void CalculaMinutos()
        {
            if (diferenciaMinutos > tiempoActualFaltanteParaTiempoActual)
            {
                Console.WriteLine(" Ocurrira en " + diferenciaMinutos + " minutos");
            }
            if (diferenciaMinutos < tiempoActualFaltanteParaTiempoActual)
            {
                Console.WriteLine(" Ocurrio hace " + diferenciaMinutos * -1 + " minutos");
            }
        }
        public void CalculaTiempoConcurridoEnEventos()
        {
            //Calcula tiempo
            CalculaMeses();
            CalculaDias();

            if(diferenciaDias == tiempoActualFaltanteParaTiempoActual && diferenciaMeses == tiempoActualFaltanteParaTiempoActual)
            {
                CalculaHoras();

                if (diferenciaHoras == tiempoActualFaltanteParaTiempoActual)
                {
                    CalculaMinutos();
                }
            }

        }

    }
}