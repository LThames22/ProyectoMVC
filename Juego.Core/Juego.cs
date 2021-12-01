using System;
using System.Collections.Generic;

namespace Juego.Core
{
    public class Juego
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public DateTime FechaEstreno {get;set;}
        public string Descripcion {get;set;}
        public float Peso {get;set;}
        public Genero Genero {get;set;} 
        
    }
}
