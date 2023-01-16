using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Galpon<T>
    {
        private List<T> listElement;
        private string _sector; 
        private int _idElemento;
        private int _lugarOcupado;

        private Galpon()
        {
            listElement = new List<T>();
        }

        public Galpon( string sector, int idElemento, int lugarOcupado ): this()
        { 
            _sector = sector;
            _idElemento = idElemento;
            _lugarOcupado = lugarOcupado;
            
        }
        public void Add(T elem)
        {
            listElement.Add(elem);

        }
        public int CantidadElementos
        {
            get { return listElement.Count; }
        }

        public T Primerelemento()
        {
            return listElement[0];
        }

        public bool GuardarObjeto ( T ObjParaGuardar)
        {
            return true;
        }

        public List<T> ListElement { get => listElement; set => listElement = value; }
    }
}
