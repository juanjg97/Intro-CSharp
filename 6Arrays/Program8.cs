using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declaracion Array 2D
            string[,] matriz2D;

            //Declaración Array 3D
            string[,,] matriz3D;


            // /////////////////////////////////////////////// Array 2S
            string[,] array2D = new string[,]
            {
                {"A","B","C"},
                {"D","E","F"},
                {"G","H","I"}
            };    

            //El primer índice indica los renglones y el segundo las columnas
            Console.WriteLine("\nEl elemento central es: {0}",array2D[1,1]);
            Console.WriteLine("El elemento inferior izquierdo es : {0}", array2D[2, 0]);

         
            
            ////////////////////////////////////////////////////////////Array3D
            string[,,] array3D = new string[,,]
            {
                {
                     {"A","B","C"},
                     {"D","E","F"},
                     {"G","H","I"}
                },
                {
                    {"J","K","L"},
                    {"M","N","Ñ"},
                    {"O","P","Q"}
                },
               
                {
                    {"R","S","T"},
                    {"U","V","W"},
                    {"X","Y","Z"}
                }
                  

            };

            //El primer índice indica las matrices , el segundo los renglones y el tercero las columnas
            Console.WriteLine("\nEl elemento central de la primera Matriz es: {0}",array3D[0,1,1]);
            Console.WriteLine("El central derecho de la tercera Matriz es:  {0}", array3D[2, 1, 2]);

            //Para conocer las dimesiones de la matriz necesiamos usar la propiedad .Rank

            int dimArray3D = array3D.Rank;
            Console.WriteLine("\nLa dimensión del Array3D es: {0}",dimArray3D);


            // Otra manera de declarar arrays
            string[,] arrayNombre = new string[3, 2]
            {
              {"Juan José","Jasso"},
              {"Carlos ","Jasso" },
              {"Verónica","Garduño"}
            };


            Console.WriteLine("Ahora vamos a cambiar el nombre de carlos por alejandro");
            arrayNombre[1, 0] = "Alejando";
            Console.WriteLine("El primer elemento del sengundo renglón es: {0} ",arrayNombre[1,0]);



            Console.Read();
        }
    
    }

}
