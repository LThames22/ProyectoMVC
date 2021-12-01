using System.Collections.Generic;

namespace Juego.Core

{
    public class Desarroladora

    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Juego> Juegos { get; set; }
        
        public Desarroladora() => Juegos = new List<Juego>();
        public void AgregarJuego(Juego juego)
            => Juegos.Add(juego);
    }
}