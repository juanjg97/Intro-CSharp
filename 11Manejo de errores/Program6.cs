using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioSesion
{
    class Program
    {

        static string correo, contraseña; //Las variables globales también deben ser static, ya que son utilizadas por main

        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al creador de cuentas de correo\n");
            Registro();
            Inicio();
           
            Console.ReadKey();

        }


        public static void Registro()
        {
            Console.WriteLine("Ingrese su nuevo correo");
            correo = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese su nueva contraseña");
            contraseña = Console.ReadLine();

        }

        public static void Inicio()
        {
            Console.WriteLine("\nInicie Sesión\n");

            Console.WriteLine("Ingrese su correo");
            string correoUs = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese su contraseña");
            string contraseñaUs = Console.ReadLine();

            if (contraseñaUs.Equals(contraseña) && correoUs.Equals(correo))
            {
                Console.WriteLine("Bienvenido a su cuenta de correo");
            }
            else
            {
                Console.WriteLine("Datos incorrectos");
            }
        }


    }
}
