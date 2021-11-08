using Microsoft.AspNetCore.Mvc;
using SuperSimple.Core;

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
            var Genero = Repositorio.GetCategoria(id);
            if (Genero is null)
            {
                return NotFound();
            }
            return View(Genero);
        }

        [HttpGet]
        public IActionResult FormAlta() => View();

        [HttpPost]
        public IActionResult FormAlta(Categoria categoria)
        {
            Repositorio.ActualizarCategoria(Genero);
            return View("Index", Repositorio.Genero);
        }
    }
}