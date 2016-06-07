using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMantenimiento.Models
{
    public class Reporte
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReporteId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Fecha_Reporte { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Fecha_Realizado { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [ScaffoldColumn(false)]
        public string Estado { get; set; }

        [ForeignKey("Usuario")]
        public int UserId { get; set; }

        [ForeignKey("Equipo")]
        public int EquipoId { get; set; }

        [ScaffoldColumn(false)]
        public int User_RealizadoId { get; set; }

        [Display(Name = "Asignar a: ")]
        public int User_AsignadoId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Equipo Equipo { get; set; }

    }
}