using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIf2
{
    class Program
    {
        static int PuntuacionTop=100;
        static string jugadorTop="Juan";
        
        static void Main(string[] args)
        {
          
            Console.WriteLine("Introduzca el nombre del jugador");
            string nombJugador = Console.ReadLine();

            Console.WriteLine("Ingrese el puntaje del jugador");
            int pObtenido = int.Parse(Console.ReadLine());


            PuntuacionJug(pObtenido,nombJugador);
            Console.ReadKey();

        }




        public static void PuntuacionJug(int puntajeObtenido, string nombreJugador)
        {
           

            if (puntajeObtenido > PuntuacionTop)
            {
                Console.WriteLine("La nueva puntuación más alta es: " + puntajeObtenido + "lograda por: " + nombreJugador);
            }
            else if (puntajeObtenido == PuntuacionTop)
            {
                Console.WriteLine("Se igualó la puntuación más alta de: " + puntajeObtenido);
            }
            else
            {
                Console.WriteLine("La puntuación más alta de " + PuntuacionTop + " no se ha podido superar, y aún está en manos de " + jugadorTop);
            }

            

        }

    




    }
}
