using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    class Caja
    {
        //Atributos 
        private int largo;
        private int alto;
        // private int ancho;
        private int volumen;

        ////////////////////////////////Métodos
        public void muestraInfo()
        {
            Console.WriteLine("El largo es, {0} la altura es {1}" +
                " el ancho es {2} el volumen es: {3}",largo, alto, Ancho,Volumen);
        }
        public void Superficie_Frontal()
        {
            Console.WriteLine("La superficie frontal es: {0}", SuperficieFrontal);
        }

        ///////////////////////////////Constructor

        public Caja (int largo, int alto, int ancho)
        {
            this.largo = largo;
            this.Ancho = ancho;
            this.alto = alto;
        }

        //////////////////////////////PROPIEDADES

        public int SuperficieFrontal
        {
            get => this.alto * Ancho;

        }


        public int Volumen
        {

            set
            {
                volumen = value;
            }
            
            get
            {
                return (Alto* Largo * Ancho);
            }


        }

        public int Alto 
        {
            set
            {
                this.alto = value;
                if (value < 0) throw new Exception("El valor ingresado debe ser positivo");
            }

            get
            {
                return this.alto;
            }
              
          
        
        }

/*
        public int Largo
        {
            set
            {
                this.largo = value;
            }

            get
            {
                return this.largo;
            }

        }
*/

        public int Largo
        {
            get => this.largo;
            set => this.largo = value;
        }


        public int Ancho { get; set; }


       
            







        //public void settearLargo(int largo)
        //{
        //    this.largo = largo;
        //}

        //public int gettearLargo()
        //{
        //    return this.largo;
        //}
    }
}
