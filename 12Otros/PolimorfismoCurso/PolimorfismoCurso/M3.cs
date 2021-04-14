using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoCurso
{
    class M3:BMW
    {
        //Constructor
        public M3(int hp, string color, string modelo) : base(hp, color, modelo)
        {
            this.Modelo = modelo;
        }

        public override void Reparar()
        {
            base.Reparar();
        }
    }
}
