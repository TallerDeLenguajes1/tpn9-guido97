using System;
using System.IO;

namespace TP9.Helpers
{
    public static class IODeTexto
    {
        public static void EscribirArchivo(string ubicacion,string nombre,string contenido)
        {
            Directory.CreateDirectory(ubicacion);
            FileStream archivo = new FileStream(ubicacion+nombre, FileMode.Create);
            StreamWriter stream = new StreamWriter(archivo);
            stream.Write(contenido);
            stream.Close();
        }

        public static string LeerArchivo(string pathArchivo)
        {
            FileStream archivo = new FileStream(pathArchivo, FileMode.Open);
            StreamReader stream = new StreamReader(archivo);
            string leido = stream.ReadToEnd();
            stream.Close();
            return leido;
        }

    }
}
