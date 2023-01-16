using CLArchivos;
using System;
using System.Text;
using System.Text.Json;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool win = OperatingSystem.IsWindows();

            Console.WriteLine($"Es windowS? = {win}");

            bool lin = OperatingSystem.IsLinux();

            Console.WriteLine($"Es linux? = {lin}");

            var so = Environment.OSVersion;
            var plataforma = Environment.OSVersion.Platform;
            var version = Environment.OSVersion.Version.ToString();
            var salto = Environment.NewLine;

            Console.WriteLine($"SO {so}");
            Console.WriteLine($"Plataforma {plataforma}");
            Console.WriteLine($"Salto {salto}");
            Console.WriteLine($"Version {version}");


            Console.WriteLine("{0, -10} | {1, -10} | {2, -7} | {3, -26} | {4, -26} |",
            "Nombre", "Tipo", "Formato", "Tamaño", "Espacio libre");

            foreach (DriveInfo unidad in DriveInfo.GetDrives())
            {
                if (unidad.IsReady)
                {
                    Console.WriteLine("{0, -10} | {1, -10} | {2, -7} | {3, 20:N0} bytes | {4, 20:N0} bytes |",
                    unidad.Name, unidad.DriveType, unidad.DriveFormat, unidad.TotalSize,
                    unidad.AvailableFreeSpace);
                }
                else
                {
                    Console.WriteLine("{0, -10} | {1, -10}", unidad.Name, unidad.DriveType);
                }
            }

            Console.WriteLine("Directorio {0}",Path.DirectorySeparatorChar);
            Console.WriteLine("Directorio Separator char {0}",Path.GetRandomFileName());
            var path = Path.Combine("mai", "utn");
            Console.WriteLine("path {0}",path);
            Console.WriteLine("{0}",Directory.GetCurrentDirectory());

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Linea 3 ");
                sb.AppendLine("Linea 2 ");
                File.WriteAllText("Archivo.txt", sb.ToString());

            }
            catch(Exception)
            {
                //trow;
            }finally
            {
                //Liberar Recursos
            }

            StreamWriter sw = null!;
            try
            {
                sw = new StreamWriter("aaarchvoSW.txt");
                sw.WriteLine("Linea 3 ");
                sw.WriteLine("Linea 2 ");
                sw.Write("linea");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                if(sw is not null)
                sw.Close();
                sw.Dispose();
            }
            // Leer Archivo

            var path2 = "Archivo.txt";
            var lecturaAll = File.ReadAllText(path2);

            Console.WriteLine(" lectura Todo junto  ");
            Console.WriteLine(lecturaAll);

            var lecturaLineaPorLinea = File.ReadAllLines(path2);

            Console.WriteLine(" lectura linea por linea ");
            foreach (var item in lecturaAll)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("====== STREAM READER =======");

            var sr = File.OpenText(path2);

            Console.WriteLine(sr.ReadToEnd());

            sr.Close();
            sr.Dispose();

            //Serializacion json
            var archivo = new Archivo("persona.json");
            var listaPersonas = new List<Persona>();

            var persona = new Persona("ivan", 37557926);           
            listaPersonas.Add(persona);
            listaPersonas.Add(new Persona("ivan",333333));

            var opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            var personaJason = JsonSerializer.Serialize(listaPersonas,opciones);

            Console.WriteLine(personaJason);
            if(archivo.Escribir(personaJason))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("no ok");
            }
            var lectura = archivo.LeerTodoElArchivo();
            var peronsaDeserializada = JsonSerializer.Deserialize<List<Persona>>(lectura);

            foreach (var item in peronsaDeserializada)
            {
                Console.WriteLine($"descerializado{item}");
            }
        }
    }
}