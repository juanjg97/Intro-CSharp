using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manejo_de_archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer el texto completo.
            //Generamos una variable, para recibir el contenido del archivo.
            string contenido = System.IO.File.ReadAllText(@"C:\Users\User\Documents\000 CURSOS\C#\11Manejo de archivos\Prueba.txt");
            Console.WriteLine("El archivo contiene el siguiente contenido: {0}", contenido);


            //Leer de a líneas
            string[] lineas = System.IO.File.ReadAllLines(@"C:\Users\User\Documents\000 CURSOS\C#\11Manejo de archivos\Prueba.txt");
            foreach(string linea in lineas)
            {
                Console.WriteLine("\t"+linea);
            }

            Console.Read();


        }
    }
}
