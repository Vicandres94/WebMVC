using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMantenimiento.Models
{
    public class Sede
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SedeId { get; set; }
        [Required]
        public string NombreSede { get; set; }
        [ForeignKey("Universidad")]
        public int UniversidadId { get; set; }
        public virtual Universidad Universidad{ get; set; }
        public virtual List<Bloque> Bloques { get; set; }
    }
}