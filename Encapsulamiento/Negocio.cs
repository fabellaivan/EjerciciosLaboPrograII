using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string _nombre;


        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }
            set { _ =  this + value; }
        }
        private Negocio()
        {            
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            Nombre = nombre;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach (Cliente item in n.clientes)
            {
                if (c == item)
                {
                    retorno = true;
                }
                    
            }
            return retorno;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if (n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if (n.clientes.Count > 0)
            {
                retorno = n.caja.Atender(n.Cliente);
            }
            return retorno;
        }
        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }



    }
}
