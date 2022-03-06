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
    }
}