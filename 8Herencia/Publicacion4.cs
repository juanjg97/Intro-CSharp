using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Publicacion
    {
        //Atributos
        private static int publicacionID;


        //Propiedades
        protected int ID { get; set; }
        protected string Titulo { get; set; }
        protected string Autor { get; set; }

        protected bool EsPublico { get; set; }

        //Constructor vacío

        public Publicacion()
        {
            ID = 0;
            Titulo = "Mi primera publicación";
            Autor = " Juan José";
            EsPublico = true;
        }

        //Constructor parametrizado
        public Publicacion(string Titulo, string Autor, bool esPublico)
        {
            this.ID = CrearID();
            this.Autor = Autor;
            this.EsPublico = esPublico;
            this.Titulo = Titulo;
        }

        //Métodos 

        //Crear un ID
        protected int CrearID()
        {
            return ++publicacionID;
        }

        //Editar el titulo de la publicacion
        protected void Editar(string nuevoTitulo,bool esPublico)
        {
            this.Titulo = nuevoTitulo;
            this.EsPublico = esPublico;
        }

        //Método para transformar todo a string

        public override string ToString()
        {
            return String.Format("{0} - {1} - Creado por {2}"
                ,this.ID,this.Titulo,this.Autor);
        }



    }
}
