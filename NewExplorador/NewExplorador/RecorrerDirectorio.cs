
using System;
using System.Collections.Generic;
using System.IO;

namespace NewExplorador
{
    internal class RecorrerDirectorio
    {
        private string strDirectorio;
        private List<Items> itContenido;
        private List<string> extensiones;


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

            extensiones = new List<string>();
            extensiones.Add("Cualquiera");


            for (int i = 0; i < directories.Length; i++)
            {
                itContenido.Add(new Items(directories[i].FullName, directories[i]));
                if (i == 0)
                {
                    extensiones.Add("<DIR>");
                }

            }



            for (int i = 0; i < files.Length; i++)
            {
                itContenido.Add(new Items(files[i].FullName, files[i]));
                if (!extensiones.Contains(files[i].Extension))
                    extensiones.Add(files[i].Extension);

            }

        
           

        }

        internal object filtrar(string selectedItem)
        {
            List<Items> resultado = new List<Items>();
            foreach (var item in itContenido)
            {
                if (item.Tipo==selectedItem)
                    resultado.Add(item);
            }

            return resultado;


        }

        internal object ObtenerExtensiones()
        {
            return extensiones;
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