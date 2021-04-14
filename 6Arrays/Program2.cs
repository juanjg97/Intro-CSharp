using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayComoParametro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones = new int [] { 7,10,10,10 };
            int i = 1;
         
            foreach(int calificacion in calificaciones)
            {
                Console.WriteLine("La calificación no: {0} es: {1}", i, calificacion);
                i++;
            }
            Console.WriteLine("\n");
            ObtenerPromedio(calificaciones);
           
            //Array con saldo de los clientes
            
            
            
            Console.ReadKey();



        }

        static void ObtenerPromedio(int[] ArrayPuntaje)
        {
            
            int suma = 0;
            int cantidad = ArrayPuntaje.Length;
          

            foreach (int calificacion in ArrayPuntaje)
            {
                suma = suma + calificacion;
            
            }

            double  promedio = (double) suma / cantidad;

            Console.WriteLine("El promedio es: {0}", promedio);
        
        }

        
        
    }
}
