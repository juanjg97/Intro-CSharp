//ESTRUCTURA DE C#

//NameSpace o espacio de nombres, que contienen ya código previo, clases etc.
// Estos spaces names se mantienen en gris hasta que se utiliza alguna función de ellos, asi sabemos cuales nos sirven y cuales no


using System;

namespace HolaMundo  //Estamos creando un nuevo espacio de nombres
{
    class Program  //Clase con nombre program
    {

                    
        static void Main(string[] args) //Método,cuando ejecutamos un programa lo primero que se realiza son las instrucciones del main
        {
            //Dentro del método vamos a escribir todo el código que queremos que se ejecute , haga nuestro programa
            
            //Ejemplo de propiedades 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();


            Console.WriteLine("Hola Mundo"); //Console está alojado en System, por lo que se pinta de blanco.

  

            Console.Read(); //Establece orden de que ingresemos algo antes de que se cierre el programa, es otra opción a ReadKey
        }
    }
}
