using System;
using System.Collections;
using System.IO;
namespace VisualizadorEventosSistema
{
    public class Lectura_ArchivoTXT
    {
      ArrayList lineasArchivoTXT = new ArrayList();      
        public void lecturaArchivo(string NombreArchivo)
        {
            string ArchivoNombre;
            ArchivoNombre = NombreArchivo;
            string linea;
            try
            {
                StreamReader miLector = new StreamReader(ArchivoNombre+".txt");
                do
                {
                    linea = miLector.ReadLine();
                    if (linea != null)
                    {
                        lineasArchivoTXT.Add(linea);
                    }
                } while (linea != null);
                miLector.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
               // Console.WriteLine("Executing finally block.");
            }
        }
        public ArrayList getArrayListLineasArchivoTXT()
        {
            return lineasArchivoTXT;
        }
    }
}