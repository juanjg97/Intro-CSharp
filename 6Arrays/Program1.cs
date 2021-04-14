using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregarBono
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] saldos = new double[] {1500,2250,36.58,78.41,55.23 };

            saldos=AgregarBono(saldos);

            int i = 0;
            foreach(int saldo in saldos)
            {
                Console.WriteLine("El nuevo saldo de la cuenta {0} es: {1} ",i,saldos[i]);
                i++;
            }

            Console.ReadKey();

        }

        public static double[] AgregarBono(double[] saldos)
        {
            double bono = 200;
            int i = 0;
            double[] saldoConBono = new double[saldos.Length];

            foreach (double saldo in saldos)
            {

                saldoConBono[i] = saldos[i] + bono;
                i++;
            
            }

            return saldoConBono;
            
        }
    }
}
