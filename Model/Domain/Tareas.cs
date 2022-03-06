using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Domain
{
    public class Tareas
    {
        [Key]
        public int idtarea { get; set; }

        [Required]
        public int estadotarea { get; set; }

        [Required]
        public DateTime fechainicio { get; set; }

        public DateTime fechafin { get; set; }

        [Required]
        public int prioridad { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string descripcion { get; set; }

        [Required]
        public bool archivado { get; set; }

        [Required]
        public int idusuariocreador { get; set; }
        [Required]
        public int idusuarioasignado { get; set; }
        [Required]
        public int idusuariotermino { get; set; }
        [Required]
        public int idcategoriatarea { get; set; }
    }
}
