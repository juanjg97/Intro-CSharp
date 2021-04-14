using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    class Program
    {

        const double PI = 3.1415;
        const int semanas = 52, meses = 12, dias = 365;
        const string nacimiento = "27.11.97";

        static void Main(string[] args)
        {

            Console.WriteLine("Mi nacimiento fue el: {0}",nacimiento);

            Console.ReadKey();
        }
    }
}
