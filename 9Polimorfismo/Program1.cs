using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
#region

            var autos = new List<Auto>
            {
                new AUDI(200,"azul","A4"),
                new BMW(250, "rojo","M3")
            };

            foreach (var auto in autos)
            {
                auto.Reparar();
            }

            Auto auto1 = new BMW(200, "negro", "Z3");
            Auto auto2 = new AUDI(100, "verde", "A3");

            auto1.MostrarDetalles();
            auto2.MostrarDetalles();

            BMW bmwM5 = new BMW(330, "blanco", "M5");
            bmwM5.MostrarDetalles();

            Auto autoB = (Auto)bmwM5;
            autoB.MostrarDetalles();
#endregion


            M3 mim3 = new M3(350, "rojo", "Super Turbo");
            mim3.Reparar();

            //Damos y leemos la información
            auto1.SettearComprador(123456, "Juan José");
            auto1.GettearComprador();

            Console.Read();
        }
    }
}
