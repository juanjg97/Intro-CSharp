using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTORES
{
    class Humano
    {
        //Miembros "variables" de la clase
        private string nombre = "";
        private string apellido = "";
        private int edad = 0;
        private string colorDeOjos = "";



        //Constructor
        public Humano(string nombre, string apellido, int edad, string colorDeOjos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.colorDeOjos = colorDeOjos;

        }


        //Miembro "método del constuctor"

        public void Presentarse()
        {
            Console.WriteLine("Hola, mi nombre es: {0} {1} tengo {2} años y mi color de ojos es {3} ", nombre, apellido, edad, colorDeOjos);
        }




    }
}
