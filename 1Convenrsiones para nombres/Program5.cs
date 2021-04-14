using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversión explicita

            double miDouble = 13.35;
            int miInt;
            miInt = (int)miDouble;

            ///////////////////////////////

            //Conversión inmplicita

            int num = 1234;
            long numg = num;

            float miFloat = 13.37F;
            double miNuevoDouble = miFloat;

            ///////////////////////////////////////////

            // Conversión de tipo
          
            string miString = miDouble.ToString(); 

            bool elSolBrilla = true;
            string miBoolString = elSolBrilla.ToString();
         

            Console.WriteLine(miInt);

            Console.WriteLine(numg);

            Console.WriteLine(miFloat);

            Console.WriteLine(miNuevoDouble);

            Console.WriteLine(miString);

            Console.WriteLine(miBoolString);

            Console.ReadKey();


        }
    }
}
