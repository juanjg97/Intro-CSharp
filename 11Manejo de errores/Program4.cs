using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWhile
{
    class Program
    {
        static void Main(string[] args)
        {
           int contador = 0;
           string valor = "";


            while(valor.Equals(""))
            {
                Console.WriteLine("Ingrese ENTER para agregar un alumno, para finalizar ingrese otro valor");

                valor = Console.ReadLine();
                
                contador++;
                
            }

            Console.WriteLine("El número de alumnos es: "+ contador);

            Console.Read();

        }
    }
}
