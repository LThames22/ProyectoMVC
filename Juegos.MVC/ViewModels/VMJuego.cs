using Juegos.Core;
using System.Collections.Generic;

namespace Juegos.MVC.ViewModels
{
    public class VMJuego
    {
        public IEnumerable<Genero> Generos { get; set; }
        public Juego Juego { get; set; }
        public int? IdGeneroSeleccionado { get; set; }
        public VMJuego() => Juego = new Juego();
        public VMJuego(IEnumerable<Genero> generos) : this()
            => Generos = generos;

        public VMJuego(Juego juego)
        {
            Juego = juego;
        }
    }
}