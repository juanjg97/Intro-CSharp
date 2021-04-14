using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class M3:BMW
    {
        //Constructor parametrizado en M3
      
        
        public M3(int hp, string color, string modelo) : base(hp, color, modelo)
        {
            this.Modelo = modelo;
        }

        public void Reparar()
        {
            base.Reparar();
        }
    }
}
