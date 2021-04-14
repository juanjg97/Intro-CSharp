using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioArrayDentado
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] personas= new string[][]
            {
                    new string[] {"Juan","Daniela","Gerry" },
                    new string[] {"Carlos","Andrea","Fello","Pugises" },
                    new string[] {"Veronica","Juan José"}
            };

            //Para presentar a Daniela con Pugises usariamos los siguientes indices


            Console.WriteLine("Hola {0}, soy {1}", personas[0][1], personas[1][3]);

            Console.Read();


         }
    }
}
