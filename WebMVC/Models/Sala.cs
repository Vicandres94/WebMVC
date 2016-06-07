using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMantenimiento.Models
{
    public class Sala
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalaId { get; set; }

        [Required]
        [Display(Name = "Nombre de Sala")]
        public string NombreSala { get; set; }

        [ForeignKey("Piso")]
        public int PisoId { get; set; }

        public virtual Piso Piso { get; set; }


        public virtual List<Equipo> Equipos { get; set; }
    }
}