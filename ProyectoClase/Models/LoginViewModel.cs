using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoClase.Models
{
    public class LoginViewModel
    {

        [Required]
        public string correo { get; set; }


        [Required]
        public string password { get; set; }
        public string ErrorMessage { get; set; }
    }
}
