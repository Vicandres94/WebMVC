using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMantenimiento.Models
{
    public class Piso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PisoId { get; set; }
        [Required]
        public int Num_Piso { get; set; }
        [ForeignKey("Bloque")]
        public int BloqueId { get; set; }
        public virtual Bloque Bloque { get; set; }
        public virtual List<Sala> Salas { get; set; }
    }
}