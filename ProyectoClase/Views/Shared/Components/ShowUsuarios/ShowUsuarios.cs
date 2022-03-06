using Microsoft.AspNetCore.Mvc;
using Service;
namespace ProyectoClase.Views.Shared.Components.ShowUsuarios
{
    public class ShowUsuarios : ViewComponent
    {
        private readonly IUsuarioService _usuarioService;
        public ShowUsuarios (IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_usuarioService.ShowAll());
        }
    }
}
