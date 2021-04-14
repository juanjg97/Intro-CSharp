﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            var autos = new List<Auto>
            {
                new Audi(200,"azul","A4"),
                new BMW(250, "rojo","M3")
            };

            foreach(var auto in autos)
            {
                auto.Reparar();
            }

            Auto auto1 = new BMW(200, "negro", "Z3");
            Auto auto2 = new Audi(100, "verde", "A3");

            auto1.MostrarDetalles();
            auto2.MostrarDetalles();

            BMW bmwM5 = new BMW(330, "blanco", "M5");
            bmwM5.MostrarDetalles();

            Auto autoB = (Auto)bmwM5;
            autoB.MostrarDetalles();

            M3 miM3 = new M3(260, "rojo", "M3Super Turbo");
            miM3.Reparar();




            Console.Read();
        }
    }
}
