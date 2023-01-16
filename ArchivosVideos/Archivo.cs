using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosVideos
{
    public class Archivo
    {
        static string ruta;

        static Archivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos";
        }

        public static void Escribir()//Metodo
        {
            //string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);///Generamos una ruta al escritorio

            //string rutaProyecto = AppDomain.CurrentDomain.BaseDirectory;//Ruta donde esta el prorgama/proyecto 

            string rutaCompleta = ruta + @"\LaboSW" + ".txt";
            // importante la barra separadora.

            //StreamWriter sw = new StreamWriter(ruta + nombreArchivo);
            //sw.WriteLine("Primera Linea");
            //sw.WriteLine("Segunda Linea");
            //sw.Close();
            //sw.Dispose();

            try
            {
                if(!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(rutaCompleta,true))
                //Con el segundo parametro(true) indicamos a StreamWriter no pise el excel, sino que 
                //Agregue lineas al .txt. Si es FALSE, pisaria el archivo. Por default, es false. 
                //using es unbloque de codigo donde se puede de
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine("Escrito");
                }
            }
            catch(Exception e)
            {
                //Logger.log($"Log");Se crea una clase logger para los logs.
                throw new Exception($"Error{rutaCompleta}");
            }
        }
        public static string Leer(string archivo)//Metodo
        {
            string datos = string.Empty;
            try
            {

                if (Directory.Exists(ruta))
                {
                    string rCompleta = ruta + $@"\{archivo}" + ".txt";
                    //string line;
                   
                    using (StreamReader sr = new StreamReader(rCompleta))
                    {
                        datos = sr.ReadToEnd();
                        //while ((line = sr.ReadLine()) != null)
                        //{
                        //    datos += "\n"+line;
                        //}

                    }
                }
               
            }
            catch (Exception e)
            {
                //Logger.log($"Log");Se crea una clase logger para los logs.
                throw new Exception($"Error{ruta}");
            }

            return datos;

        }
    }
}
