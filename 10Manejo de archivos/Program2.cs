using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscribirArchivos
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] nombres = {"Juan","Daniela","Suchi","Daniela" };

            File.WriteAllLines(@"C:\Users\User\Documents\000 CURSOS\C#\11Manejo de archivos\Prueba.txt",nombres);




            //Archivo para manetener los puntajes y que no se modifique el texto

            using (StreamWriter archivo = new StreamWriter(@"C:\Users\User\Documents\000 CURSOS\C#\11Manejo de archivos\Prueba.txt"))
            {
                foreach (string nombre in nombres)
                {
                    if(nombre.Contains("J"))
                    {
                        archivo.WriteLine(nombre);
                    }
                }
            }

            using (StreamWriter archivo = new StreamWriter(@"C:\Users\User\Documents\000 CURSOS\C#\11Manejo de archivos\Prueba.txt",true))
            {
                archivo.WriteLine("Hola");
            }

        }
    }
}
