using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionJson
{
    public class ClaseSerializadora<T>
    {
        static string ruta;

        static ClaseSerializadora()//ATENCION AL STATIC
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos_SerializadorJson";
        }


        #region Escribir

        public static void EscribirCSV(T datos, string archivo)
        {
            string rutaCompleta = ruta + @"\SerializadorCsv" + archivo + ".csv ";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string csvSerializado = CsvSerializer<datos>

                File.WriteAllText(rutaCompleta, objJason);


            }
            catch (Exception)
            {
                throw;
            }
        }


        public static void EscribirJSON(T datos, string archivo)
        {
            string rutaCompleta = ruta + @"\SerializadorJson" + archivo + ".json ";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                
                string objJason = JsonSerializer.Serialize(datos);

                File.WriteAllText(rutaCompleta, objJason);


            }
            catch (Exception)
            {
                throw;
            }
        }

   
        #endregion Escribir

        #region Leer 

        public static T Leer(string nombreReferencia)//string rutaCompleta
        {
            string archivo = string.Empty;
            T date = default;
            bool ok = false;
            try
            {
                if(Directory.Exists(ruta))
                {
                    string[] archivosDeDirectorio = Directory.GetFiles(ruta);

                    foreach(string item in archivosDeDirectorio)
                    {
                        if(item.Contains(nombreReferencia))
                        {
                            archivo = item;
                            ok = true;  
                            break;
                        }
                    }

                    if(ok == true)
                    {
                        string archivoJson = File.ReadAllText(archivo);
                        date = JsonSerializer.Deserialize<T>(archivoJson);
                        
                    }
                    else
                    {
                        Console.WriteLine("No hay coincidencias");
                    }


                }

            }
            catch (Exception)
            {
                throw;
            }
            return date;
        }


        #endregion
    }
}
