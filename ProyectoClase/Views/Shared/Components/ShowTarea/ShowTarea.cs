using Microsoft.AspNetCore.Mvc;
using Service;
namespace ProyectoClase.Views.Shared.Components.Show_Tareas
{
    public class ShowTarea : ViewComponent
    {
        private readonly ITareaService _tareaService;

        public ShowTarea(ITareaService tareaService)
        {
            _tareaService = tareaService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_tareaService.ShowAlltar());
        }

    }
}
