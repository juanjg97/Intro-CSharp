using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MétodosDos
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = Sumar(10, 10);
            Console.WriteLine("Forma 1: "+resultado);


            Console.WriteLine("Forma 2:" + Sumar(5, 5));

           
            Console.WriteLine("El resultado de la multiplicación de 3 x 3 es: " + Multiplicar(3, 3));

            Console.WriteLine("El resultado de dividir 3 /2 es: " + Dividir(3, 2));

            
            Console.ReadKey();
            
        }

        public static int Sumar(int numUno, int numDos)
        {
            return numUno + numDos;
        }

        public static int Multiplicar(int numUno,int numDos)
        {
            return numUno * numDos;
        }

        public static float  Dividir (float numUno, float numDos)
        {
            return numUno / numDos;
        }

    }
}
