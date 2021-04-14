using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTORES
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano juan = new Humano("Juan José", "Jasso", 22, "Café");
            Humano daniela = new Humano("Daniela", "Moreno", 21, "Café");

            juan.Presentarse();
            daniela.Presentarse();

            Console.ReadKey();


        }
    }
}
