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
            string nombre;

            try
            {

                Console.WriteLine("Bienvenido a un programa para divisiones");
                Console.WriteLine("Ingresa tu nombre");
                nombre = Console.ReadLine();
                 Console.WriteLine("Ingresa el numerador");
                float numerador = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el denominador");
                float denominador = float.Parse(Console.ReadLine());
                if (denominador == 0)
                {
                    throw (new DivideByZeroException("El denominador debe ser diferente de cero"));
                } 
                float division = numerador / denominador;
                Console.WriteLine("El numerador es: " + division);
                
            }
            catch (Exception e1)
            {

                Console.WriteLine("Compruebe sus datos: "+e1.Message);
             
            }
            finally
            {
                Console.WriteLine("Gracias");
            }



            Console.ReadKey();

        }
    }
}
