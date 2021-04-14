using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un objeto
            //Una instancia de humano
            Humano juan = new Humano();

            juan.nombre = "Juan José Jasso";
            juan.Presentarme();


            Humano pedro = new Humano();
            pedro.Presentarme();
            pedro.nombre = "Pedro Vazquez";
            pedro.Presentarme();


            Humano carlos = new Humano();
            Humano daniela = new Humano();

            carlos.nombre = "Carlos Jasso";
            daniela.nombre = "Daniela Moreno";

            carlos.year = 2000;
            daniela.year = 1998;

            Console.WriteLine("\n\n");

            carlos.Presentarme2();
            daniela.Presentarme2();




            Console.ReadKey();
      
        }
    }
}
