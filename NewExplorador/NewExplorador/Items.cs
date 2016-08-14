using System.IO;

namespace NewExplorador
{
    internal class Items
    {
        private FileInfo file;
        private DirectoryInfo direc;

        private enum Tipo
        {
            Archivo,
            Directorio
        };
        private Tipo tipo;


        public Items(string nombre,FileInfo i)
        {
            file = i;
            tipo = Tipo.Archivo;
            
        }

        public Items(string nombre, DirectoryInfo i)
        {
            direc = i;
            tipo = Tipo.Directorio;

        }

    }
}