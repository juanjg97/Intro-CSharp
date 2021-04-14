using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer texto completo
            string texto = System.IO.File.ReadAllText(@"C:\Users\Win10\Desktop\Textos\LeerArchivoTexto.txt");
            Console.WriteLine("El archivo contiene el siguiente texto: {0}", texto);

            //Leear de a líneas
            string[] lineas = System.IO.File.ReadAllLines(@"C:\Users\Win10\Desktop\Textos\LeerArchivoTexto.txt");
            foreach(string linea in lineas)
            {
                Console.WriteLine("\t" + linea);
            }

            Console.Read();
        }
    }
}
