using System;
using System.Collections.Generic;
using System.Linq;

namespace Juego.Core
{
    public static class Repositorio
    {
        static int idDesarrolladora = 1;
        static int idGenero = 1;
        static int idJuego = 1;

        static readonly List<Desarroladora> desarolladoras = new List<Desarroladora>();
        public static Desarroladora GetDesarrolladora(int id)
        => desarolladoras.Find(p => p.Id == id);
        public static void AgregarCategoria(Desarroladora desarrolladora)
        {
            desarrolladora.Id = idDesarrolladora++;
            desarolladoras.Add(desarrolladora);
        }
        static readonly List<Genero> generos = new List<Genero>();
        public static IEnumerable<Genero> Generos => generos;
        public static Genero GetGenero(int id)
            => generos.Find(g => g.Id == id);
        public static void AgregarGenero(Genero genero)
        {
            genero.Id = idGenero++;
            generos.Add(genero);
        }

        static readonly List<Juego> juegos = new List<Juego>();
        public static IEnumerable<Juego> Juegos => juegos;

        public static Juego GetJuego(int id)
            => juegos.Find(j => j.Id == id);
        public static void AgregarJuego(Juego juego)
        {
            juego.Id = idJuego++;
            juegos.Add(juego);
        }

    }
}