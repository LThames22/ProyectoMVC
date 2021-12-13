using Microsoft.AspNetCore.Mvc;
using Juegos.Core;
using Juegos.MVC.ViewModels;

namespace Juego.Controllers
{
    public class JuegoController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        => View(Repositorio.Juegos);

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var Juego = Repositorio.GetJuego(id);
            if (Juego is null)
            {
                return NotFound();
            }
            return View(Juego);
        }
        [HttpGet]

        public IActionResult FormAlta(int? idGenero)
        {
            var vmJuego= new VMJuego(Repositorio.Generos)
            {
            IdGeneroSeleccionado = idGenero
            };
            return View(vmJuego);
        }

        [HttpPost]

        public IActionResult FormAlta(Juego juego)
        {
            Repositorio.AgregarJuego(juego);
            return View("index", Repositorio.Juegos);
        }
    }
}