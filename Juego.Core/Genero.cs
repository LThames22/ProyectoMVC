using System.Collections.Generic;

namespace Juego.Core

{
    public class Genero
    {

        public int Id{ get; set; }
        public string Nombre { get; set; }
        public List<Juego> Juegos { get; set; }

        public Genero() => Juegos = new List<Juego>();
        public void AgregarJuego(Juego juego)
            => Juegos.Add(juego);
    }
}