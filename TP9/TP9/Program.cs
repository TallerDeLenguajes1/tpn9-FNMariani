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
            //Ejercicio 1
            /*
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
            */

            

            //Ejercicio 2
            string frase, fraseAMorse, fraseATexto;
            string directorio = System.Environment.CurrentDirectory;

            Console.WriteLine("Ingrese una frase a convertir: ");
            frase =  Console.ReadLine();

            //Escritura de archivo
            fraseAMorse = Helpers.ConversorDeMorse.TextoAMorse(frase.ToUpper());
            //Console.WriteLine(fraseAMorse);
            string archivo = @"morse\tToMorse." + DateTime.Now.ToString("dd-MM-yyyy-HH.mm.ss") + ".txt";
            if (!File.Exists(archivo))
            {
                var file = File.Create(archivo);
                file.Close();
            }
            File.WriteAllText(archivo, fraseAMorse);


            //Lectura de archivo
            string cadenaMorse = File.ReadAllText(archivo);
            fraseATexto = Helpers.ConversorDeMorse.MorseATexto(cadenaMorse);
            Console.WriteLine("\nCodigo morse leido de archivo: " + cadenaMorse);
            Console.WriteLine("Texto convertido del codigo morse: " + fraseATexto);

            //Guardamos archivo convertido a texto
            archivo = @"morse\mToTexto." + DateTime.Now.ToString("dd-MM-yyyy-HH.mm.ss") + ".txt";
            if (!File.Exists(archivo))
            {
                var file = File.Create(archivo);
                file.Close();
            }
            File.WriteAllText(archivo, fraseATexto);

            Console.ReadKey();
        }
    }
}
