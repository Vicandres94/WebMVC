using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMantenimiento.Models
{
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolId { get; set; }
        [Required]
        public string Tipo_Rol { get; set; }
        public virtual List<Usuario> Usuarios { get; set; }
    }
}