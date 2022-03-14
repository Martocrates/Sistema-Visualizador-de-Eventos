using System;
using System.Collections;
using System.IO;
namespace VisualizadorEventosSistema
{
    public class LecturaArchivo
    {
      ArrayList lineasArchivoTXT = new ArrayList();
        string nombreArchivo;
        string extensionArchivo;
        
        string linea;

        public LecturaArchivo(string NombreArchivo, string ExtensionArchivo)
        {
            extensionArchivo = ExtensionArchivo;
            nombreArchivo = NombreArchivo;

            try
            {
                StreamReader miLector = new StreamReader(nombreArchivo + extensionArchivo);
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

        public ArrayList getListaEvento()
        {
            return lineasArchivoTXT;
        }
    }
}