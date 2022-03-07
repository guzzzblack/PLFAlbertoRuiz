using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Domain;
using ProyectoClase.Models;
using Service;
using System.Linq;

namespace ProyectoClase.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ProyectoDbContext _contextcat;
        private readonly ICategoriaService _categoriaservice;
        public CategoriasController(ProyectoDbContext context, ICategoriaService categoriaservice)
        {
            _categoriaservice = categoriaservice;
            _contextcat = context;
        }
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
        //INSERTAR CATEGORIAS EN LA TABLA DE SQL
        [HttpPost]
        public IActionResult Insertcat(RegistroCatViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Registrarse", model);
            }
            else
            {
                var categoria = new Categorias
                {
                    nombrecategoria = model.nombrecategoria,
                    descripcioncategoria = model.descripcioncategoria,
                    activo = true
                };
                _categoriaservice.Create(categoria);
                return RedirectToAction("Index", "Principal");
            }
        }
    }
}
