using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class BMW:Auto
    {
        //Variables
        private string marca = "BMW";

        //Propiedad
        public string Modelo { get; set; }

        //Constructor en BMW
        public BMW(int hp, string color,  string modelo) : base(hp, color)
        {
            this.Modelo = modelo;
        }

        //Métodos
        public new void MostrarDetalles()
        {
            Console.WriteLine("Marca: {0} " +
                "- Modelo: {1} - HP: {2} - Color: {3}"
                , marca, Modelo, HP, Color);
        }

        public sealed override void Reparar()
        {
            Console.WriteLine("El BMW" +
                " {0} está reparado", Modelo);
        }
    }
}
