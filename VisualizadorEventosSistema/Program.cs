using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorEventosSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Lectura_ArchivoTXT.lecturaArchivo();

            SeparadorFechasEventos informacionMiEvento = new SeparadorFechasEventos();
            informacionMiEvento.BuscaFechasEventos();

            Console.ReadLine();
            
        }
    }
}
