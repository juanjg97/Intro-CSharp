using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
          

            //Array con tamaño indefinido
            ArrayList miArrayList = new ArrayList();

            //Array con tamaño definido
            ArrayList Array2 = new ArrayList(5);
/*
            Array2.Add(0);   
            Array2.Add("Hola");
            Array2.Add('N');
            Array2.Add(25.3);

            for (int i=0; i<Array2.Count; i++)
            {
                Console.WriteLine("El elemento {0} en Array2 es: {1}",i,Array2[i]);
                
            }

            //Para eliminar elementos

            Console.WriteLine("\nAhora borramos el segundo elemento en Array2");
            Array2.RemoveAt(1);
            for (int i = 0; i < Array2.Count; i++)
            {
                Console.WriteLine("El elemento {0} en Array2 es: {1}", i, Array2[i]);
                
            }
   */

            miArrayList.Add(1.3);
            miArrayList.Add(2);
            miArrayList.Add("Hola");
            miArrayList.Add("Megan");

            double sumaNumeros = 0;

            foreach(object obj in miArrayList)
            {
                if(obj is int)
                {
                    sumaNumeros = sumaNumeros + Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sumaNumeros += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }

            }


            Console.WriteLine(sumaNumeros);
            Console.Read();

        }
    }
}
