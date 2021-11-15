using Microsoft.AspNetCore.Mvc;
using Juegos.Core;
using Juegos.MVC.ViewModels;

namespace Juego.MVC.Controllers
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
            var vmJuego = new VMJuego(Repositorio.Generos)
            {
                IdGeneroSeleccionado = idGenero
            };
            return View(VMJuego);
        }

        [HttpPost]
        public IActionResult FormAlta(VMJuego vMJuego)
        {
            if (Validar(vMJuego))
            {
                var Genero = Repositorio.GetGenero(vMJuego.IdGeneroSeleccionado.Value);
                vMJuego.Juego.AgregarJuego(vMJuego.juego);
                FechaEstreno.AgregarJuego(vMJuego.Juego);
                Descripcion.AgregarJuego(vMJuego.Juego);
                Peso.AgregarJuego(vMJuego.Juego);
            }
            return View("Index", Repositorio.Juegos);          
        }
        [HttpPost]
        public IActionResult Modificar(VMJuego vmJuego)
        {
            if (Validar(vmJuego))
            {
                var juego = Repositorio.GetProducto(vmJuego.Juego.Id);
                if (juego is null)
                {
                    return NotFound();
                }
                vmJuego.Actualizar(juego);
            }
            return View("Index", Repositorio.Juegos);
        }
    }
}