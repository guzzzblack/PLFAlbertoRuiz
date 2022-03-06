using System.ComponentModel.DataAnnotations;

namespace ProyectoClase.Models
{
    public class RegistroCatViewModel
    {

        [Required]
        public string nombrecategoria { get; set; }
        [Required]
        public string descripcioncategoria { get; set; }
        [Required]
        public bool activo { get; set; }

    }
}
