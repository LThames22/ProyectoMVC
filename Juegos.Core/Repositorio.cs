using System;
using System.Collections.Generic;

namespace Juegos.Core
{
    public class Repositorio
    {
        static int idDesarolladora = 1;
        static int idGenero = 1;
        static int idJuego = 1;
        
        #region genero
        static readonly List<Genero> generos = new List<Genero>(); 
        public static IEnumerable<Genero> Generos
        => generos;
        public static Genero GetGenero(int id)
            => generos.Find(g => g.Id == id);
        public static void AgregarGenero(Genero genero)
        {
            genero.Id = idGenero++;
            generos.Add(genero);
        }
        #endregion
        #region juego
        static readonly List<Juego> juegos = new List<Juego>(); 
        public static IEnumerable<Juego> Juegos
        => Juegos;
        public static void AgregarJuego(Juego juego)
        {
            juego.Id = idJuego++;
        }
        #endregion



    }
}
