using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DesafioLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al programa para calcular promedio de calificaciones");
            Console.WriteLine("Ingrese cada calificación y presione enter, cuando termine de agregar calificaciones, escriba 'FIN' \n");

            int numMateria = 1;
            string ingreso = "";
            float calificacion = 0;
            float suma = 0;

            while (true)
            {
                Console.WriteLine("Ingrese la calificación de la materia No. [" + numMateria + "] o escriba FIN ");
                ingreso = Console.ReadLine();
                if (float.TryParse(ingreso, out calificacion))
                {
                    if (calificacion >= 0 && calificacion <= 10)
                    {
                        suma = suma + calificacion;
                        numMateria++;
                    }
                    else
                    {
                        Console.WriteLine("Ingresa un número dentro del intervalo");
                        continue;
                    }

                }
                else if (ingreso.Equals("FIN"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Datos erroneos");
                }

            }

            Console.WriteLine("El promedio del alumno es: " + (suma/(numMateria-1)));

            Console.ReadKey();


        }
    }
}
