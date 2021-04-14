using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class PublicacionImagen : Publicacion
    {
        //Propiedades propias de imagen

        protected string URLImage { get; set; }

        //Constructor vacío

        public PublicacionImagen() { }

        //Constructor Parametrizado
        public PublicacionImagen(string titulo, string autor, string urlImagen, bool esPublico)
        {
            this.ID = CrearID();

            this.Titulo = titulo;
            this.Autor = autor;
            this.EsPublico = esPublico;

            this.URLImage = urlImagen;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - Creado por {3}", this.ID, this.Titulo,this.URLImage ,this.Autor);
        }


    }
}
