using System;
namespace VisualizadorEventosSistema

{
    public class ImpresionConsola
    {
      
        public void DesplegarOcurrio(int cantidad, string tiempo)
        {
            Console.WriteLine(" Ocurrio hace "+ Math.Abs(cantidad) + tiempo);

        }
        public void DesplegarOcurrira(int cantidad, string tiempo)
        {
            Console.WriteLine(" Ocurrira en " + cantidad + tiempo);
        }
   
        public void DesplegarEvento(string evento)
        {
            Console.Write(evento);
        }
    }
}