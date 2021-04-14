using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Humano
    {
        //Miembro nombre de la variable
        public string nombre = "";

        //Miembro Método
        public void Presentarme()
        {
            Console.WriteLine("Hola, mi nombre es: " + nombre);
        }

        //Miembro año de nacimiento
        public int year = 0;

        //Miembro Método saludar 2
        public void Presentarme2()
        {
            Console.WriteLine("Mi nombre es: " + nombre + " ,mi año de nacimiento es: " + year);

        }

    }    

    
}
