using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMantenimiento.Models
{
    public class Bloque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BloqueId { get; set; }
        [Required]
        public string NombreBloque { get; set; }
        [ForeignKey("Sede")]
        public int SedeId { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual List<Piso> Pisos { get; set; }

    }
}