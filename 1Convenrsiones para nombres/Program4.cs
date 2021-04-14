using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcing
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            string miString = "15";
            string miSegundoString = "10";

            string resultado = miString + miSegundoString;

            Console.WriteLine(resultado);


            int num1 = Int32.Parse(miString);
            int num2 = Int32.Parse(miSegundoString);

            int resultado2 = num1 + num2;
            Console.WriteLine(resultado2);
            Console.Read();






        }
    }
}
