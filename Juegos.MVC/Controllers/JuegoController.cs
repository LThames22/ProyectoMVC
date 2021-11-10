using Microsoft.AspNetCore.Mvc;
using Juegos.Core;

namespace Juego.Controllers
{
    public class JuegoController: Controller
    {
        [HttpGet]
        public IActionResult Index()
            => View(Repositorio.Juegos);
        
        public IActionResult Detalle(int id)
        {
            var juego = Repositorio.GetJuego(id);
            if (juego is null)
            {
                return NotFound();
            }
            return View(juego);
        }

        [HttpGet]
        public IActionResult FormAlta(int? idGenero)
        {
            var vmJuego = new VMProducto(Repositorio.Generos)
            {
                IdGeneroSeleccionado = idGenero
            };
            return View(vmJuego);
        }

        [HttpPost]
        public IActionResult FormAlta(VMProducto vmJuego)
        {
            if (Validar(vmJuego))
            {
                var Genero = Repositorio.GetGenero(vmJuego.IdGeneroSeleccionado.Value);
                vmJuego.Juego.AgregarJuego(vmJuego.juego);
                FechaEstreno.AgregarJuego(vmJuego.Juego);
                Descripcion.AgregarJuego(vmJuego.Juego);
                Peso.AgregarJuego(vmJuego.Juego);
            }
            return View("Index", Repositorio.Juegos);
        }
    }
}