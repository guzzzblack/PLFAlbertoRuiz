using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Domain;
using ProyectoClase.Models;
using Service;
using System.Linq;

namespace ProyectoClase.Controllers
{
    public class LoginController : Controller
    {
        // MANDAR A LLAMAR A LA FUNCION CONTEXT 
        private readonly ProyectoDbContext _context;
        private readonly IUsuarioService _usuarioservice;
        public LoginController(ProyectoDbContext context, IUsuarioService usuarioservice)
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
        public ActionResult Valida(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _context.Usuario.Where(x => x.correo == model.correo && x.password == model.password).SingleOrDefault();
                if (result != null)
                {
                    return RedirectToAction("Index", "Principal");
                }
                else
                {
                    return RedirectToAction("Index", new { message = "Usuario o Password Incorrectos" });
                }
            }
            else
            {
                return RedirectToAction("Index", new { message = "Correo o Password Vacios" });

            }
        }
        [HttpPost]
        public IActionResult Insert(RegistroViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Registrarse", model);
            }
            var result = _context.Usuario.Where(x => x.correo == model.correo);
            if (result.Count() == 0)
            {
                var usuario = new Usuario
                {
                    correo = model.correo,
                    password = model.password,
                    tipousuario = model.tipousuario,
                    nombre = model.nombre,
                    apellido = model.apellido
                };
                _usuarioservice.Create(usuario);
                return RedirectToAction("Index", "Principal");
            }
            else
            {
                return View("Registrarse", new { message = "Usuario Existente" });
            }
        }

    }
}