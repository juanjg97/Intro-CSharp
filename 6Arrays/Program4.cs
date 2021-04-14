using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primera manera de crear arrays/////////////////////////////
            int[] calificaciones = new int[5];

            calificaciones[0] = 10;
            calificaciones[1] = 7;
         
            Console.WriteLine("Ingresa una calificación");
            string ingreso = Console.ReadLine();
            calificaciones[1] = int.Parse(ingreso);
            Console.WriteLine("Primera califiación= {0}",calificaciones[0]);

           
            //Segunda manera de crear un array//////////////////////////

            int[] edades = { 17, 18, 19 };

            //Tercera manera de crear un array//////////////////////////

            int[] numeroFaltas = new int[] { 1, 2, 3 };

            Console.WriteLine(edades.Length);

            Console.ReadLine();
        }
    }
}
