using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMantenimiento.Models
{
    public class Universidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UniversidadId { get; set; }
        [Required]
        public string Nombre { get; set; }
        public virtual List<Sede> Sedes { get; set; }

    }
}