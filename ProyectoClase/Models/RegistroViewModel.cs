using System.ComponentModel.DataAnnotations;

namespace ProyectoClase.Models
{
    public class RegistroViewModel
    {

        [Required]
        public string correo { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public int tipousuario { get; set; }

        [Required]
        public string nombre { get; set; }

        [Required]
        public string apellido { get; set; }

    }
}
