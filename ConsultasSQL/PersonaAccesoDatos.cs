using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasSQL
{
    public static class PersonaAccesoDatos
    {
        static string sqlBajaLogica = "UPDATE EMPLEADO SET ESTA_ACTIVO = 0 WHERE NOMBRE = @nombre and APELLIDO = @apellido";
        static string sqlAltaLogica = "UPDATE EMPLEADO SET ESTA_ACTIVO = 1 WHERE NOMBRE = @nombre and APELLIDO = @apellido";

        static string conectionString;
        static SqlCommand sqlCommand;
        static SqlConnection conection;

        static PersonaAccesoDatos()
        {

            conectionString = @"Data Source =.;
                                Database = EMPRESA_DB;
                                Trusted_Connection = True";

            sqlCommand = new SqlCommand();
            conection = new SqlConnection(conectionString);
            sqlCommand.Connection = conection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();

            try
            {

                sqlCommand.CommandText = "SELECT * FROM EMPLEADX";
                conection.Open();
                SqlDataReader dtaReader = sqlCommand.ExecuteReader();

                while (dtaReader.Read())
                {
                    Persona auxPersona = (Persona)dtaReader;

                    personas.Add(auxPersona);

                }
                return personas;

            }
            catch
            {
                throw;
            }
            finally
            {
                conection.Close();
            }
        }

        public static void AddPersona(Persona persona)//podria retornar un int donde int sea la canitadad de lineas ingresadas
        {
            try
            {
                sqlCommand.Parameters.Clear();
                conection.Open();
                sqlCommand.Parameters.AddWithValue("@nombre", persona.Nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", persona.Apellido);
                sqlCommand.Parameters.AddWithValue("@id_puesto", persona.Id_puesto);
                sqlCommand.Parameters.AddWithValue("@salario", persona.Salario);
                sqlCommand.CommandText = "INSERT INTO EMPLEADX(NOMBRE,APELLIDO,ID_PUESTO,SALARIO)" +
                                         "VALUES( @nombre,@apellido,@id_puesto,@salario)";


                sqlCommand.ExecuteReader();

            }
            catch
            {
                throw;
            }
            finally
            {
                if (conection.State == System.Data.ConnectionState.Open)
                {
                    conection.Close();
                }

            }
        }

        public static void Change(Persona person)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                conection.Open();
                sqlCommand.Parameters.AddWithValue("@nombre", person.Nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", person.Apellido);
                sqlCommand.Parameters.AddWithValue("@id_puesto", person.Id_puesto);
                sqlCommand.Parameters.AddWithValue("@salario", person.Salario);
              
                sqlCommand.CommandText = "UPDATE EMPLEADX set NOMBRE =  @nombre WHERE APELLIDO=@apellido";


                sqlCommand.ExecuteReader();

            }
            catch
            {
                throw;
            }
            finally
            {
                if (conection.State == System.Data.ConnectionState.Open)
                {
                    conection.Close();
                }

            }
        }

        static void Delete(int id)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                conection.Open();
                sqlCommand.Parameters.AddWithValue("@id",id);
                sqlCommand.CommandText = "DELETE FROM EMPLEADX WHERE ID_EMPLEADO = @id" ;

                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }
            finally
            {
                if (conection.State == System.Data.ConnectionState.Open)
                {
                    conection.Close();
                }

            }
        }
    

    }
}
