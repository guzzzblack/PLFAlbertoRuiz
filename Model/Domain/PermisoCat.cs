using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Domain
{
    public class PermisoCat
    {
        [Key]
        public int idpermiso { get; set; }

        [Required]
        public int idcategoria { get; set; }
        [Required]
        public int idusuariopermitido { get; set; }
    }
}
