using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoClase.Models
{
    public class PermisoViewModel
    {

        [Required]
        public int idcategoria { get; set; }
        [Required]
        public int idusuariopermitido { get; set; }
    }
}
