using System.Text.Json;

namespace CLArchivos
{
    public class Archivo
    {
        private string _path;
        private float _size;
        private bool _isOpen;

        public bool IsOpen { get { return _isOpen; } }

        public int Size { get => 1; }
     
        public Archivo(string path)
        {
            _path = path;
            _size = 0;
            _isOpen = false;
        }

        public string LeerTodoElArchivo()
        {
            string retorno = File.ReadAllText(_path);
            return retorno;
        }

        public bool Escribir(string datos)
        {
            try
            {
                File.WriteAllText(_path, datos);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Escribir(List<string> datos, bool append)
        {
            StreamWriter sw = null!;

            try
            {
                sw = new StreamWriter("archivoSW.txt", append);

                _isOpen = true;

                foreach (var linea in datos)
                {
                    sw.WriteLine(linea);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                if (sw is not null)
                {
                    sw.Close();
                    sw.Dispose();
                    _isOpen = true;
                }
            }

            return true;
        }

        public bool Escribir(Persona person)
        {
            StreamWriter sw = null!;

            var archivo = new Archivo("persona.json");
            var persona = new Persona("ivan",37557926);

            var opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            var personaJason = JsonSerializer.Serialize(persona);

            Console.WriteLine(personaJason);

            var lectura = archivo.LeerTodoElArchivo();

            foreach(var item in lectura)
            {
                Console.WriteLine(item);
            }           

            return true;
        }
    }
}