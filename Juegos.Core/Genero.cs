using System;
using System.Collections.Generic;

namespace Juegos.Core
{
    public class Genero
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public List<Juego> Juego{get;set;}
        public Genero()
        {
            Juego = new List<Juego>();
        }

        public void AgregarJuego(Juego juego)
            => Juego.Add(juego);
    }
}
