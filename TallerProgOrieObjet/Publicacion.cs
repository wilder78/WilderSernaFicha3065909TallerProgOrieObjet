using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgOrieObjet
{
    public class Publicacion
    {
        private string _autor;
        private string _contenido;
        private DateTime _fechaPublicacion;

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public string Contenido
        {
            get { return _contenido; }
            set { _contenido = value; }
        }

        public DateTime FechaPublicacion
        {
            get { return _fechaPublicacion; }
            set { _fechaPublicacion = value; }
        }

        public Publicacion(string autor, string contenido)
        {
            Autor = autor;
            Contenido = contenido;
            FechaPublicacion = DateTime.Now;
        }

        public virtual void MostrarPublicacion()
        {
            Console.WriteLine($"Publicación de {Autor} el {FechaPublicacion:dd/MM/yyyy HH:mm}");
            Console.WriteLine($"Contenido: {Contenido}");
        }
    }

    public class PublicacionTexto : Publicacion
    {
        public PublicacionTexto(string autor, string contenido) : base(autor, contenido) { }

        public override void MostrarPublicacion()
        {
            Console.WriteLine("--- PUBLICACIÓN DE TEXTO ---");
            base.MostrarPublicacion();
        }
    }

    public class PublicacionImagen : Publicacion
    {
        public string UrlImagen { get; set; }

        public PublicacionImagen(string autor, string contenido, string urlImagen) : base(autor, contenido)
        {
            UrlImagen = urlImagen;
        }

        public override void MostrarPublicacion()
        {
            Console.WriteLine("--- PUBLICACIÓN DE IMAGEN ---");
            base.MostrarPublicacion();
            Console.WriteLine($"URL de la imagen: {UrlImagen}");
        }
    }

    public class PublicacionVideo : Publicacion
    {
        public string UrlVideo { get; set; }
        public int Duracion { get; set; }

        public PublicacionVideo(string autor, string contenido, string urlVideo, int duracion) : base(autor, contenido)
        {
            UrlVideo = urlVideo;
            Duracion = duracion;
        }

        public override void MostrarPublicacion()
        {
            Console.WriteLine("--- PUBLICACIÓN DE VIDEO ---");
            base.MostrarPublicacion();
            Console.WriteLine($"URL del video: {UrlVideo}");
            Console.WriteLine($"Duración: {Duracion} segundos");
        }
    }
}
