using System;

namespace Juegos.Core
{
    public class Genero
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public Genero()
        {
            Juego = new List<Juegos>();
        }

        public void AgregarJuego(Juegos juego)
            => Juego.Add(juego);

    }
}
