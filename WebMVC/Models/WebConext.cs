using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMantenimiento.Models
{
    public class WebConext: DbContext
    {
        public WebConext(): base("WebContext") {
        }
        DbSet<Universidad> Universidades { get; set; }
        DbSet<Sede> Sedes { get; set; }
        DbSet<Bloque> Bloques { get; set; }
        DbSet<Piso> Pisos { get; set; }
        DbSet<Sala> Salas { get; set; }
        DbSet<Equipo> Equipos { get; set; }
        DbSet<Reporte> Reportes { get; set; }
        //DbSet<Usuario> Usuarios { get; set; }
        //DbSet<Rol> Roles { get; set; }
        

        public System.Data.Entity.DbSet<WebMantenimiento.Models.Rol> Rols { get; set; }

        public System.Data.Entity.DbSet<WebMantenimiento.Models.Usuario> Usuarios { get; set; }
    }
}