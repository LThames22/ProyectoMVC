using System;

namespace Juegos.Core
{
    public class Juego
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public datetime FechaEstreno {get;set;}
        public string Descripcion {get;set;}
        public float Peso {get;set;}
        public List<Genero> Generos { get; set; }
        public Juego()
        {
            Generos = new List<Genero>();
        }

        public void AgregarGenero(Genero generos)
            => Generos.Add(generos);
        
    }
}
