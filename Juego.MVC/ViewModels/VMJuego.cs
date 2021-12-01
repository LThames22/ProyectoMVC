using Juegos.Core;
using System.Collections.Generic;

namespace Juegos.MVC.ViewModels
{
    public class VMJuego
    {
        public IEnumerable<Genero> Generos { get; set; }
        public Juegos Juego { get; set; }
        public int? IdGeneroSeleccionado { get; set; }
        public VMJuego() => Juego = new Juegos();
        public VMJuego(IEnumerable<Genero> generos) : this()
            => Generos = generos;

        public VMJuego(Juegos juego)
        {
            Juego = juego;
        }
    }
}