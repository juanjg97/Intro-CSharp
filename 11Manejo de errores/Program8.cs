using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura = -5;
            string fase;

            if (temperatura < 0)
            {
                fase = "Sólida";
            }
            else if(temperatura>0 && temperatura<100)
            {
                fase = "líquida";
            }
            else
            {
                fase = "gaseosa";
            }
            Console.WriteLine("La fase del agua es: " + fase);



            string faseX = temperatura < 0 ? "Sólido" : temperatura < 99? "Líquido"  : "Gaseoso";
            Console.WriteLine("La fase del agua es: " + faseX);


            Console.ReadKey();

        }
    
    
    
    
    }
}
