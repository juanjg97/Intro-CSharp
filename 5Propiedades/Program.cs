using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Caja caja = new Caja(3,3,3);
         
            caja.muestraInfo();

            caja.Superficie_Frontal();

            int sF = caja.SuperficieFrontal;
            Console.WriteLine("Otra manera de ver la superficie frotnal: {0}", sF);

            Console.Read();


        }
    }
}
