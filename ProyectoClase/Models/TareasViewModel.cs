using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoClase.Models
{
    public class TareasViewModel
    {
        [Required]
        public int estadotarea { get; set; }

        [Required]
        public DateTime fechainicio { get; set; }

        public DateTime fechafin { get; set; }

        [Required]
        public int prioridad { get; set; }

        public string descripcion { get; set; }

        [Required]
        public bool archivado { get; set; }

        [Required]
        public int idusuariocreador { get; set; }
        [Required]
        public int idusuarioasignado { get; set; }
        public int idusuariotermino { get; set; }
        [Required]
        public int idcategoriatarea { get; set; }

    }
}
