using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDentados
{
    class Program
    {
        static void Main(string[] args)
        {
            //A diferencia de un array multidimencional, ahora usamos doble [][]

            int[][] dentado = new int[3][]; //Declaramos el array

            dentado[0] = new int[5];  //Declaramos el número de valores de cada a
            dentado[1] = new int[3];
            dentado[2] = new int[2];


            dentado[0] = new int[] { 0, 1, 2, 3, 4 }; //Le damos valores a los array
            dentado[1] = new int[] { 5, 6, 7 };
            dentado[2] = new int[] { 8, 9 };

            int[][] dentado2 = new int[][] //Otra manera de llenar los array
            {

                 new int[] { 0, 1, 2, 3, 4 },
                 new int[] { 0, 1, 2 },
                 new int[] { 0, 1 },
            };


            Console.WriteLine("El valor en el medio del primer array es: {0}", dentado2[0][2]);
            Console.WriteLine("\nEl último valor del segundo array es: {0}", dentado2[1][2]);
            Console.WriteLine("\nEl primer valor del último array es: {0}", dentado2[2][0]);

            for (int i = 0; i < dentado2.Length; i++)
            {

                for (int j = 0; j < dentado2[i].Length;j++)
                {
                    Console.WriteLine("El elemento en la posición [{0}][{1}] es: {2}",i,j,dentado2[i][j]);
                }
            
            };

            Console.Read();








        }
    }
}
