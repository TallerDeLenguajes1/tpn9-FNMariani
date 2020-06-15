using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace TP9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribimos archivo de configuracion de destino
            string ruta = @"C:\Taller1\tpn9-FNMariani\TP9\TP9\bin\Debug\destino\";
            Helpers.SoporteParaConfiguracion.CrearArchivoDeConfiguracion(ruta);

            //Leemos destino dentro del archivo de configuracion
            string rutaDeLectura = Helpers.SoporteParaConfiguracion.LeerConfiguracion();

            //Listamos archivos
            string directorio = System.Environment.CurrentDirectory;
            List<string> listadoDeArchivos = Directory.GetFiles(directorio).ToList();
            foreach (string archivo in listadoDeArchivos)
            {
                Console.WriteLine(archivo);

                //Si el archivo tiene extension .mp3 o .txt, lo movemos
                FileInfo file = new FileInfo(archivo);
                if( (file.Extension == ".mp3") || (file.Extension == ".txt") )
                {
                    string nuevoDestino = rutaDeLectura + file.Name;
                    File.Move(archivo, nuevoDestino);
                }
            }

            Console.ReadKey();
        }
    }
}
