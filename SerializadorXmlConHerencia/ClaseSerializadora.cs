using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializadorXmlConHerencia
{
    public class ClaseSerializadora<T>
    {
        static string ruta;

        static ClaseSerializadora()//ATENCION AL STATIC
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos_Serializador";
        }


        #region Escribir
        public static void Escribir(T datos, string archivo)
        {
            string rutaCompleta = ruta + @"\SerializadorUnitario" + archivo + DateTime.Now.ToString("HH_mm_ss") + ".xml ";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(sw, datos);
                }
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
                        using (StreamReader sr = new StreamReader(archivo))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                            date = (T)xmlSerializer.Deserialize(sr);
                        }
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
