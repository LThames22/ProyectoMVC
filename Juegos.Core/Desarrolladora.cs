using System;

namespace Juegos.Core
{
    public class Desarrolladora
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public list<Juegos> Juego{get;set;}
        public Desarrolladora()
        {
            Juego = new List<Juegos>();
        }

        public void AgregarJuego(Juegos juego)
            => Juego.Add(juego);

    }
}
