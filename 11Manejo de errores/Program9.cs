﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int autos = 3;

            switch (autos)
            {
                case 0:
                    Console.WriteLine("Usted no paga impuestos");
                    break;
                case 1:
                    Console.WriteLine("Usted $15");
                    break;
                case 2:
                    Console.WriteLine("Usted paga $30");
                    break;
                default:
                    Console.WriteLine("Usted paga $15 dolares por auto");
                    break;
            }

            Console.WriteLine("\n");
            //---------------------------------------------------------------

            if (autos == 0)
            {
                Console.WriteLine("Usted no paga impuestos");
            }
            else if (autos == 1)
            {
                Console.WriteLine("Usted paga $15");
            }
            else if (autos == 2)
            {
                Console.WriteLine("Usted paga $30");
            }
            else
            {
                Console.WriteLine("Usted paga $15 dolares por auto");
            }

            Console.WriteLine("\n");
            //----------------------------------------------------------------------------

            string piedraPapelTijera = "Tijera";

            switch (piedraPapelTijera)
            {
                case "Piedra":
                    Console.WriteLine("Piedra mata a tijera");
                    break;
                case "Papel":
                    Console.WriteLine("Papel mata a piedra");
                    break;
                case "Tijera":
                    Console.WriteLine("Tijera mata a papel");
                    break;
                default:
                    Console.WriteLine("Ese elemento no forma parte del juego");
                    break;
            }
            Console.Read();



        }
    }
}
