using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Publicacion post1 = new Publicacion("Gracias por los saludos","Juanjo",true);
            Console.WriteLine(post1);


            PublicacionImagen imagen1 = new PublicacionImagen("Mira mi nuevo carrito","Daniela","www.perrito",true);
            Console.WriteLine(imagen1.ToString());


            PublicacionVideo video1 = new PublicacionVideo("Mi video", "Sushi", 5,"www.video.mx",1,true );
            Console.WriteLine(video1.ToString());

            Console.WriteLine("\n");

            video1.Play();
            Console.WriteLine("Presione cualquier tecla para detener");
            Console.ReadKey();
            video1.Stop();

            Console.Read();
        }
    }
}
