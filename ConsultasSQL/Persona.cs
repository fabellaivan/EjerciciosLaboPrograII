using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasSQL
{
    public class Persona
    {
        string _nombre;
        string _apellido;
        int _id_puesto;
        double _salario;
        bool _estaActivo;

        public Persona(string nombre, string apellido,
            int id_puesto, double salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Id_puesto = id_puesto;
            Salario = salario;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Id_puesto { get => _id_puesto; set => _id_puesto = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public bool EstaActivo { get => _estaActivo; set => _estaActivo = value; }

        public static explicit operator Persona(SqlDataReader v)
        {
            Persona p = new Persona(
                v["nombre"].ToString() ?? "",
                v["apellido"].ToString() ?? "",
                 Convert.ToInt32(v["id_puesto"]),
                 Convert.ToDouble(v["salario"])
                );

            return p;
        }

        public override string ToString()
        {
            return $"\nNombre: {Nombre} " +
                $"Apellido   : {Apellido} " +
                "\n----------------------------------- " +
                $"\nidPuesto : {Id_puesto}" +
                $"\nSalario  : {Salario}" +
                $"\nEstado   : {EstaActivo}";

        }
    }
}
