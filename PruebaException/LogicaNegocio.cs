using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaException
{
    public static class LogicaNegocio
    {
        static List<Usuario> _listaUsr;
        static LogicaNegocio()
        {
            _listaUsr = new List<Usuario>();
        }
        public static string CargarUsuario(string nombre, int edad)
        {
            try
            {
                if (nombre == "")
                {
                    throw new ArgumentException("Nombre es null");
                }
                if (edad <= 0)
                {
                    //throw new Exception("Edad no puede ser 0");
                    throw new ErrorDeDatosExceptioncs("Edad no puede ser menor igual a 0");

                    //manda la excepcion al FORM1 y lo mnuestra en el catch(Exception ex)
                }
                Usuario nuevoUsr = new Usuario(nombre, edad);

                return nuevoUsr.ToString();
            }
            catch(Exception ex)
            {
                throw new Exception("Verificar info",ex);
                // Capturo la excepcion captada en el TRY
                // y le concatenamos otro mensaje 
            }

            return "";
        }
    }
}
