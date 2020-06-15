using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class SoporteParaConfiguracion
    {
        public static void CrearArchivoDeConfiguracion(string ruta)
        {
            string nuevoArchivo = "destino.dat";

            if(!File.Exists(nuevoArchivo))
            {
                File.Create(nuevoArchivo);
            }
            File.WriteAllText(nuevoArchivo, ruta);
        }

        public static string LeerConfiguracion()
        {
            string nuevoArchivo = "destino.dat";

            string ruta = File.ReadAllText(nuevoArchivo);

            return ruta;
        }
    }
}
