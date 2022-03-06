using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Domain;
using ProyectoClase.Models;
using Service;
using System.Linq;

namespace ProyectoClase.Controllers
{
    public class TareasController : Controller
    {
        // MANDAR A LLAMAR A LA FUNCION CONTEXT 
        private readonly ProyectoDbContext _context;
        private readonly IUsuarioService _usuarioservice;
        public TareasController(ProyectoDbContext context, IUsuarioService usuarioservice)
        { 
            _usuarioservice = usuarioservice;
            _context = context; 
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registrarse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(TareasViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("RegistroTarea", model);
            }
            var result = _context.Tareas.Where(x => x.descripcion == model.descripcion);
            if (result.Count() == 0)
            {
                var tarea = new Tareas
                {
                    estadotarea = model.estadotarea,
                    fechainicio = model.fechainicio,
                    prioridad = model.prioridad,
                    descripcion = model.descripcion,
                    idusuariocreador = model.idusuariocreador,
                    idusuarioasignado = model.idusuarioasignado,
                    archivado = true
                };
                //_usuarioservice.Create(tarea);
                return RedirectToAction("Index", "Principal");
            }
            else
            {
                return View("Registrarse", new { message = "Usuario Existente" });
            }
        }

    }
}