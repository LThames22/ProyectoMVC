using System;
using System.Collections.Generic;

namespace Juegos.Core
{
    public class Repositorio
    {
        static int idDesarrolladora = 1;
        static int idGenero = 1;
        static int idJuego = 1;
        
        #region genero
        static readonly List<Genero> Generos = new List<Genero>(); 
        public static IEnumerable<Genero> Generos
        => Generos;
        public static Genero GetGenero(int id)
            => Generos.Find(g => g.Id == id);
        public static void AgregarGenero(Genero Genero)
        {
            Genero.Id = idGenero++;
            Generos.Add(Genero);
        }
        #endregion
        #region juego
        static readonly List<Juego> Juegos = new List<Juego>(); 
        public static IEnumerable<Juego> Juegos
        => Juegos;
        public static Juego GetJuego(int id)
            => Juegos.Find(j => j.Id == id);
        public static void AgregarJuego(Juego Juego)
        {
            Juego.Id = idJuego++;
            Juegos.Add(Juego);
        }
        #endregion
        #region desarrolladora
        static readonly List<Desarrolladora> Desarrolladoras = new List<Desarrolladora>(); 
        public static IEnumerable<Desarrolladora> Desarrolladoras
        => Desarrolladoras;
        public static Desarrolladora GetDesarrolladora(int id)
            => Desarrolladoras.Find(d => d.Id == id);
        public static void AgregarDesarrolladora(Desarrolladora Desarrolladora)
        {
            Desarrolladora.Id = idDesarrolladora++;
            Desarrolladoras.Add(Desarrolladora);
        }
        #endregion


    }
}
