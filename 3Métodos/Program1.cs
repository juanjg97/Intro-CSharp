using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso_del_usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El resultado de la suma es: " + Sumar());

            Console.WriteLine("Segunda suma \n");

            Sumar2();

            Console.ReadKey();
        }

        public static int Sumar()
        {
            Console.WriteLine("Ingresa el primer número: ");
            string inputUno = Console.ReadLine();

            Console.WriteLine("Ingresa el segundo número: ");
            string inputDos = Console.ReadLine();

            return int.Parse(inputUno) + int.Parse(inputDos);
        }

        public static void Sumar2()
        {
            int resultado = 0;
            
            Console.WriteLine("Ingresa el primer número: ");
            string inputUno = Console.ReadLine();

            Console.WriteLine("Ingresa el segundo número: ");
            string inputDos = Console.ReadLine();

            resultado = int.Parse(inputUno) + int.Parse(inputDos);

            Console.WriteLine("El resultado de la segunda suma es: " + resultado);

        }


    }
}
