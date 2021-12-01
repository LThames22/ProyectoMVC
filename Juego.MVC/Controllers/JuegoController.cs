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
        public IActionResult FormAlta(VMJuego vMJuego)
        {
            if (Validar(vMJuego))
            {
                var genero = Repositorio.GetGenero(vMJuego.IdGeneroSeleccionado.Value);
                genero.AgregarJuego(vMJuego.Juego);
                Repositorio.AgregarJuego(vMJuego.Juego);
            }
            return View("Index", Repositorio.Juegos);
        }
        [HttpPost]
        public IActionResult Modificar(VMJuego vmJuego)
        {
            if (Validar(vmJuego))
            {
                var juego = Repositorio.GetJuego(vmJuego.Juego.Id);
                if (juego is null)
                {
                    return NotFound();
                }
            }
            return View("Index", Repositorio.Juegos);
        }
        private bool Validar(VMJuego vMJuego)
            => (vMJuego.IdGeneroSeleccionado.HasValue);
    }
}