using Juegos.Core;
using System.Collections.Generic;

namespace Juegos.MVC.ViewModels
{
    public class VMJuego
    {
        public IEnumerable<Genero> Generos { get; set; }
        public Juegos.Core.Juego JuegoVista { get; set; }
        public int? IdGeneroSeleccionado { get; set; }
        public VMJuego() => Juego = new Juego();
        public VMJuego(IEnumerable<Genero> generos) : this()
            => Generos = generos;
        public VMJuego(Juegos.Core.Juego Juego)
        {
            JuegoVista = juego;            
        }
    }
}