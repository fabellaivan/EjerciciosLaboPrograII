using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosFILE
{
    public static class ArchivosFile
    {
        static string ruta;

        static ArchivosFile()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos";
        }

        public static void Escribir(string escritura)//Metodo
        {
            string rutaCompleta = ruta + @"\LaboFile" + ".txt";

            if(escritura != string.Empty)
            {
                try
                {
                    if (!Directory.Exists(ruta))
                    {
                        Directory.CreateDirectory(ruta);
                    }
                    //File.WriteAllText(rutaCompleta,escritura);

                    File.AppendAllText(rutaCompleta,"\n" + escritura );

                    Console.WriteLine($"Ruta{rutaCompleta}\nEscritura {escritura}");
                    
                }
                catch (Exception e)
                {
                    throw new Exception($"Error{rutaCompleta}");
                }
            }
        }

        public static string Leer (string archivo)
        {
            string datos = string.Empty;
            try
            {
                if (Directory.Exists(ruta))
                {
                    string rCompleta = ruta + $@"\{archivo}" + ".txt";
                    //string line;
                    datos = File.ReadAllText(rCompleta);
                
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error{ruta}");
            }

            return datos;
        }
    }
}
