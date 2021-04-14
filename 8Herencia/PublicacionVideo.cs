using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Herencia
{
    class PublicacionVideo : Publicacion
    {
        //Variables
        protected bool seReproduce = false;
        protected int duracionActual = 0;
        Timer reloj;

        //Propiedades de la clase
        protected int DuracionVideo { get; set; }
        protected string UrlVideo { get; set; }

        //Constructore vacio

        public PublicacionVideo()
        {
            this.Titulo = " ";
            this.Autor = "Juan";
            this.DuracionVideo = 0;
            this.UrlVideo = "www.video.com";
            this.ID = 0;
            this.EsPublico = true;

        }


        //Constructore parametrizado
        public PublicacionVideo(string titulo, string autor, int duracion, string urlVideo, int id, bool esPublico)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.DuracionVideo = duracion;
            this.UrlVideo = urlVideo;
            this.ID = CrearID();
            this.EsPublico = esPublico;


        }

        //Métodos
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - Creado por {3} con duración de {4} segundos" , this.ID, this.Titulo, this.UrlVideo, this.Autor,this.DuracionVideo);
        }



        private void Reproduccion(object o)
        {
            if (duracionActual < DuracionVideo)
            {
                duracionActual++;
                Console.WriteLine("Estamos en el segundo {0}", duracionActual);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Play()
        {
            if(seReproduce is false)
            {
                seReproduce = true;
                Console.WriteLine("Reproduciendo");
                reloj = new Timer(Reproduccion, null, 0, 1000);
            }
        }

        public void Stop()
        {
           if(seReproduce is true)
           {
                seReproduce = false;
                Console.WriteLine("\nEl video está detenido en el segundo {0}", duracionActual);
                duracionActual = 0;
                reloj.Dispose();
           }
        }

   
    }
}
