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
        private readonly ProyectoDbContext _contexttar;
        private readonly ITareaService _tareaservice;
        public TareasController(ProyectoDbContext context, ITareaService tareaservice)
        {
            _tareaservice = tareaservice;
            _contexttar = context;
        }
        public IActionResult ListaTareas()
        {
            return View();
        }
        public IActionResult Tareas()
        {
            return View();
        }
        public IActionResult Creartarea()
        {
            return View();
        }
        public IActionResult Vertareas()
        {
            return View();
        }
        //INSERTAR TAREAS EN TABLA SQL
        [HttpPost]
        public IActionResult Inserttar(TareasViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("RegistroTareas", model);
            }
            else
            {
                var tareas = new Tareas
                {
                    estadotarea = 2,
                    fechainicio = System.DateTime.Now,
                    prioridad = model.prioridad,
                    descripcion = model.descripcion,
                    archivado = true,
                    idusuariocreador = model.idusuariocreador,
                    idusuarioasignado = model.idusuarioasignado,
                    idcategoriatarea = model.idcategoriatarea
                };
                _tareaservice.Create(tareas);
                return RedirectToAction("Index", "Principal");
            }
        }
    }
}