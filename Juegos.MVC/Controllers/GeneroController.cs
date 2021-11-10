using Microsoft.AspNetCore.Mvc;
using Juegos.Core;

namespace Juegos.MVC.Controllers
{
    public class GeneroController : Controller
        {  
        [HttpGet]
        public IActionResult Index()
            => View(Repositorio.Genero);

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var Genero = Repositorio.GetGenero(id);
            if (Genero is null)
            {
                return NotFound();
            }
            return View(Genero);
        }

        [HttpGet]
        public IActionResult FormAlta() => View();

        [HttpPost]
        public IActionResult FormAlta(Genero genero)
        {
            Repositorio.ActualizarGenero(Genero);
            return View("Index", Repositorio.Genero);
        }
    }
}