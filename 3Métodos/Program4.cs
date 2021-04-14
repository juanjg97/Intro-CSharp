using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeAlgo();

            EscribeAlgoEspecifico("Soy un argumento y me llamaron desde un método");

            Console.ReadKey();
        }

        public static void EscribeAlgo ()
        {
            Console.WriteLine("Yo nací en un método");
          
        }

        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
            
        }
    }
}
