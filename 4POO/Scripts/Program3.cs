using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR__VACIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano humanoBasico = new Humano("Juan José","Jasso",22,);

            humanoBasico.Presentarse();

            Console.Read();

        }
    }
}
