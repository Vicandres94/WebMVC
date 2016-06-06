using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMantenimiento.Models
{
    public class Usuario
    {     
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId {get; set;}
        public string UserName { get; set; }
        public string Password { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string TipoDocumento { get; set; }
        [Required]
        public string Documento { get; set; }
        [Required]
        public string FechaNacimiento { get; set; }
        [Required]
        public char Sexo { get; set; }
        [Required]
        public string Carrera { get; set; }
        [Required]
        public string Semestre { get; set; }
        [Required]
        public string Estado { get; set; }
        [ForeignKey("Rol")]
        public int RolId { get; set; }
        public virtual Rol Rol { get; set; }
    }
}