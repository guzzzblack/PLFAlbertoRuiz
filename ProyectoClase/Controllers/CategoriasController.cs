using Microsoft.AspNetCore.Mvc;

namespace ProyectoClase.Controllers
{
    public class CategoriasController : Controller
    {
        public IActionResult Nuevacategoria()
        {
            return View();
        }
        public IActionResult Vercategoria()
        {
            return View();
        }
        public IActionResult Permitircategoria()
        {
            return View();
        }
    }
}
