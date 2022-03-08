using System;
namespace VisualizadorEventosSistema
{
    public class CalculaTiempo
    {
        int diferenciaMeses;
        int diferenciaDias;
        int diferenciaHoras ;
        int diferenciaMinutos;
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
            if (diferenciaMeses > 0 ) {
                Console.WriteLine(" Ocurrira en " + diferenciaMeses + " meses");
            }
            if (diferenciaMeses < 0)
            {
                Console.WriteLine(" Ocurrio hace " + diferenciaMeses *-1 + " meses");
            }
        }

        private void CalculaDias()
        {
            if (diferenciaMeses == 0)
            {
                if (diferenciaDias > 0)
                {
                    Console.WriteLine(" Ocurrira en " + diferenciaDias + " dias");
                }
                if (diferenciaDias < 0)
                {
                    Console.WriteLine(" Ocurrio hace " + diferenciaDias * -1 + " dias");
                }

            }
        }

        private void CalculaHoras()
        {
            if(diferenciaHoras>0)
            {
                Console.WriteLine(" Ocurrira en " + diferenciaHoras + " horas");
            }
            if (diferenciaHoras < 0)
            {
                Console.WriteLine(" Ocurrio hace " + diferenciaHoras * -1 + " horas");
            }
        }

        private void CalculaMinutos()
        {
            if (diferenciaMinutos > 0)
            {
                Console.WriteLine(" Ocurrira en " + diferenciaMinutos + " minutos");
            }
            if (diferenciaMinutos < 0)
            {
                Console.WriteLine(" Ocurrio hace " + diferenciaMinutos * -1 + " minutos");
            }
        }
        public void TiempoConcurridoEnEventos()
        { /*
            Console.WriteLine("\n===================================================");
            Console.WriteLine(" diferenciaMeses: " + diferenciaMeses + " meses");
            Console.WriteLine(" diferenciaDias: " + diferenciaDias + " dias");
            Console.WriteLine(" diferenciaHoras: " + diferenciaHoras + " horas");
            Console.WriteLine(" diferenciaMinutos:" + diferenciaMinutos + " minutos");
            Console.WriteLine("===================================================");
            */
            //Calcula tiempo
            CalculaMeses();
            CalculaDias();

            if(diferenciaDias ==0 && diferenciaMeses == 0)
            {
                CalculaHoras();

                if (diferenciaHoras == 0)
                {
                    CalculaMinutos();
                }
            }

        }

    }
}