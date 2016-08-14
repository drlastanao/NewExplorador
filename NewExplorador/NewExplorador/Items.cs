using System.IO;

namespace NewExplorador
{
    internal class Items
    {
        private FileInfo file;
        private DirectoryInfo direc;

        public string Nombre { get; }
        public string Tipo { get; }
        public long Tamaño { get; }



        private enum enumTipo
        {
            Archivo,
            Directorio
        };
        private enumTipo tipo;


        public Items(string nombre,FileInfo i)
        {
            file = i;
            tipo = enumTipo.Archivo;

            Nombre = i.Name;
            Tipo = i.Extension;
            Tamaño = i.Length;
            
        }

        public Items(string nombre, DirectoryInfo i)
        {
            direc = i;
            tipo = enumTipo.Directorio;

            Nombre = i.Name;
            Tipo = "<DIR>";

            Tamaño = 0;
        }

    }
}