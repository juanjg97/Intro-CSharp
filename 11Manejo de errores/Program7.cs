﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //operadores unarios

            num3 = -num1;
            Console.WriteLine("El valor negativo de num1 es {0}", num3);

            bool haySol = true;
            Console.WriteLine("¿hay sol? {0}", !haySol);

            //operadores de adición

            int num = 0;
            num++;
            Console.WriteLine("num es {0}", num);
            Console.WriteLine("num es {0}", num++);
            Console.WriteLine("num es {0}", num);

            //operadores de sustracción

            num--;
            Console.WriteLine("num es {0}", num);
            Console.WriteLine("num es {0}", --num);
            Console.WriteLine("num es {0}", num);

            //operadores matematicos

            int resultado = num1 + num2;
            Console.WriteLine("El resultado de " + num1 + " + " + num2 + " es igual a " + resultado);
            resultado = num1 - num2;
            Console.WriteLine("El resultado de " + num1 + " - " + num2 + " es igual a " + resultado);
            resultado = num1 * num2;
            Console.WriteLine("El resultado de " + num1 + " * " + num2 + " es igual a " + resultado);
            resultado = num1 / num2;
            Console.WriteLine("El resultado de " + num1 + " / " + num2 + " es igual a " + resultado);

            //operador modular
            resultado = num1 % num2;
            Console.WriteLine("El resultado de " + num1 + " % " + num2 + " es igual a " + resultado);

            //operadores relacionales

            bool esMenor;
            esMenor = num1 < num2;
            Console.WriteLine("El resultado de " + num1 + " < " + num2 + " es igual a " + esMenor);

            //operadores de igualdad

            bool esIgual;
            esIgual = num1 == num2;
            Console.WriteLine("El resultado de " + num1 + " == " + num2 + " es igual a " + esIgual);

            esIgual = num1 != num2;
            Console.WriteLine("El resultado de " + num1 + " != " + num2 + " es igual a " + esIgual);

            //operadores condicionales
            //Y

            bool esMenorYSoleado;

            esMenorYSoleado = esMenor && haySol;
            Console.WriteLine("El resultado de " + esMenor + " && " + haySol + " es igual a " + esMenorYSoleado);

            //O
            esMenorYSoleado = esMenor || haySol;
            Console.WriteLine("El resultado de " + esMenor + " || " + haySol + " es igual a " + esMenorYSoleado);


            Console.Read();

        }
    }
}
