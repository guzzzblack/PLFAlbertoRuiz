using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Usuario
    {
        [Key]
        public int idusuario { get; set; }


        [Column(TypeName = "varchar(80)"), Required]
        public string correo { get; set; }


        [Column(TypeName = "varchar(80)"), Required]
        public string password { get; set; }


        [Required]
        public int tipousuario { get; set; }


        [Column(TypeName = "varchar(80)"), Required]
        public string nombre { get; set; }


        [Column(TypeName = "varchar(80)"), Required]
        public string apellido { get; set; }


    }
}
