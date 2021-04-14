using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopForEch
{
    class Program
    {
        static void Main(string[] args)
        {
            //El loop for each lo podemos usar para devolver el valor de las variables de un array o para asignarle los valores


            int[] numeros = new int[10];

            for(int i=0; i<10;i++)
            {
                numeros[i] = i;
            }     
            //Lo mejor es poner en el límite la longitud de la cadena

            for(int j=0;j<numeros.Length;j++)
            {
                Console.WriteLine("El valor del indice {0} es: {1}",j,numeros[j]);

            }
            Console.WriteLine("\n");
            
         
            //USANDO FOR EACH ################################################################################

            foreach (int k in numeros)
            {
                Console.WriteLine("El valor del indice {0} es: {1}", k, numeros[k]);
            }
            Console.WriteLine("\n");



            string[] amigos = { "Daniela", "Chad", "Victor", "Abeja", "Carlos" };

            foreach(string nombre in amigos)
            {
                Console.WriteLine("¡Hola! {0} ",nombre);
            }



            Console.Read();

        }
    }
}
