
using System.Collections.Generic;
using System.IO;

namespace NewExplorador
{
    internal class RecorrerDirectorio
    {
        private string strDirectorio;
        private List<Items> itContenido;


        public RecorrerDirectorio(string directorio)
        {
            strDirectorio = directorio;
            Recorrer();
        }


        private void Recorrer()
        {
            itContenido = new List<Items>();
                        
                
            DirectoryInfo directory = new DirectoryInfo(strDirectorio);
            FileInfo[] files = directory.GetFiles("*.*");
            DirectoryInfo[] directories = directory.GetDirectories();

            for (int i = 0; i < files.Length; i++)
            {
                itContenido.Add(new Items(files[i].FullName, files[i]));
            }

            for (int i = 0; i < directories.Length; i++)
            {
                itContenido.Add(new Items(directories[i].FullName, directories[i]));
            }

           

        }


        public List<Items> filtrar()
        {
            List<Items> resultado = new List<Items>();
            foreach (var item in itContenido)
            {
                resultado.Add(item);
            }

                return resultado;

        }






    }
}