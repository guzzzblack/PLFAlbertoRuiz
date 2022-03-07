using Microsoft.AspNetCore.Mvc;
using Service;
namespace ProyectoClase.Views.Shared.Components.ShowCategorias
{
    public class ShowCategorias : ViewComponent
    {
        private readonly ICategoriaService _categoriaService;
        
        public ShowCategorias(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }
        
        public IViewComponentResult Invoke()
        {
            return View(_categoriaService.ShowAllcat());
        }

    }
}
