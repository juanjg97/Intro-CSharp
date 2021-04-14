using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomUno = "Victor";
            string nomDos = "Chad";
            string nomTres = "Abeja";

            Saludar(nomDos);
            Saludar(nomTres);
            Saludar(nomUno);

            Console.WriteLine("\n");

            SaludarDos(nomUno, nomDos, nomTres);

            Console.Read();

        }

        public static void Saludar(string nombreAmigo)
        {
            Console.WriteLine("Hola " + nombreAmigo + " que tengas un buen día");
        }

        public static void SaludarDos(string nombreAmigo, string nombreAmigo1, string nombreAmigo2)
        {
            Console.WriteLine("Hola " + nombreAmigo + " que tengas un buen día");
            Console.WriteLine("Hola " + nombreAmigo1 + " que tengas un buen día");
            Console.WriteLine("Hola " + nombreAmigo2 + " que tengas un buen día");
        }
    }
}
