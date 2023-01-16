using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLArchivos
{
    public static class Parseador
    {
        private static bool VerificarSiExisteDirectorio(string path)
        {
            bool rtn = false;
            if(path is not null)
            {
                try
                {
                    if (Directory.Exists(path))   // Revisar si existe el directorio
                    {
                        rtn = true;
                    }
                    else
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path); //Si no existe, lo crea. 
                        rtn = di.Exists;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
           
            return rtn;
        }
        private static bool VerificarSiExisteArchivo(string path,string archivo)
        {
            bool rtn = false;
            if(path is not null)
            {
                if(VerificarSiExisteDirectorio(path))
                {
                    string rutaCompleta = path + archivo;
                    if (File.Exists(rutaCompleta))
                    {
                        rtn = true;
                    }
                    else
                    {
                        try
                        {
                            using (StreamWriter file = File.AppendText(rutaCompleta))   // crear el archivo.
                            {
                                file.WriteLine("Archivo creardo " + DateTime.Now);  //escribir el archivo.
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }  
                Console.WriteLine("Archivo Creado " + path);
            }

            return rtn;
        }
    }
}