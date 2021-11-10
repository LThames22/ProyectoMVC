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
        => juegos;
        public static Juego GetJuego(int id)
            => juegos.Find(j => j.Id == id);
        public static void AgregarJuego(Juego juego)
        {
            juego.Id = idJuego++;
            juegos.Add(juego);
        }
        #endregion
        #region desarrolladora
        static readonly List<Desarrolladora> desarrolladoras = new List<Desarrolladora>(); 
        public static IEnumerable<Desarrolladora> Desarrolladoras
        => desarrolladoras;
        public static Desarrolladora GetDesarrolladora(int id)
            => desarrolladoras.Find(d => d.Id == id);
        public static void AgregarDesarrolladora(Desarrolladora desarrolladora)
        {
            desarrolladora.Id = idDesarrolladora++;
            desarrolladoras.Add(desarrolladora);
        }
        #endregion


    }
}
