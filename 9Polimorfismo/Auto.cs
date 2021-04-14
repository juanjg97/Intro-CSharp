using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Auto
    {
        //Propiedades
        public int HP { get; set; }
        public string Color { get; set; }

        //Relación con CompradorDeAuto
        protected CompradorDeAuto comprador1 = new CompradorDeAuto();

        //Método para dar información a CompradorDeAuto
        public void SettearComprador(int id, string nombre)
        {
            comprador1.No_Serie_Auto = 123456;
            comprador1.NombreComprador = "Juan José";
        }
        public void GettearComprador()
        {
            Console.WriteLine("El ID del auto es: {0} y el comprador es: {1}", comprador1.No_Serie_Auto, comprador1.NombreComprador);
        }


        //Constructor parametrizado EN AUTO
        public Auto(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        //Métodos
        public void MostrarDetalles()
        {
            Console.WriteLine("HP: {0}" +
                " - Color: {1}", HP, Color);
        }

        public virtual void Reparar()
        {
            Console.WriteLine("El auto" +
                " ya está reparado");
        }
    }
}
