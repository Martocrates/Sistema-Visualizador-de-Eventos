using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
namespace VisualizadorEventosSistema
{
    public class Lectura_ArchivoTXT
    {
      static ArrayList lineasArchivoTXT = new ArrayList();
        public static void lecturaArchivo()
        {
            String linea;
            try
            {
                StreamReader miLector = new StreamReader("eventos.txt");
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