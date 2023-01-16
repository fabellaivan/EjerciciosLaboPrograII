using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionXml
{
    public class ClaseSerializadora
    {
        static string ruta;

        static ClaseSerializadora()//ATENCION AL STATIC
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos_Serializador";
        }


        #region Escribir
        public static void Escribir(Personaje personaje)
        {
            string rutaCompleta = ruta + @"\SerializadorUnitario" + DateTime.Now.ToString("HH_mm_ss") + ".xml ";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));
                    xmlSerializer.Serialize(sw, personaje);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Escribir(List<Personaje> personaje)
        //Sobrecarga del metodo Escribir para que reciba lista de personaje
        {
            string rutaCompleta = ruta + @"\SerializadorLista" + DateTime.Now.ToString("HH_mm_ss") + ".xml ";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Personaje>));
                    xmlSerializer.Serialize(sw, personaje);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion Escribir

        #region

        public static Personaje Leer(string rutaCompleta)//string rutaCompleta
        {
            //string rutaCompleta = ruta + @"\SerializadorUnitario.xml ";
             Personaje pj;

            try
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));

                    pj = (Personaje)xmlSerializer.Deserialize(sr);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return pj;
        }

        public static List<Personaje> LeerLista(string rutaCompleta)//string rutaCompleta
        {
            //string rutaCompleta = ruta + @"\SerializadorUnitario.xml ";
            List<Personaje> pjs = null;

            try
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Personaje>));

                    pjs = (List<Personaje>)xmlSerializer.Deserialize(sr);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return pjs;
        }
        #endregion
    }
}
