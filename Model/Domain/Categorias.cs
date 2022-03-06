using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Domain
{
    public class Categorias
    {
        [Key]
        public int idcategoria { get; set; }

        [Column(TypeName = "varchar(45)"), Required]
        public string nombrecategoria { get; set; }
        [Column(TypeName = "varchar(250)"), Required]
        public string descripcioncategoria { get; set; }
        [Required]
        public bool activo { get; set; }
    }
}
