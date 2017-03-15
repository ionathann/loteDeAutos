using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using DataAccess.Data;

namespace DataAccess.Context
{
    public class DtContext : DbContext
    {
         public DtContext() : base("DtContext")
        {

        }

        public virtual DbSet<Usuario> usuarios { get; set; }
        public virtual DbSet<Rol> roles { get; set; }
        public virtual DbSet<Permiso> permisos { get; set; }
        public virtual DbSet<PermisoNegadoRol> permisosnegadosrol { get; set; }
        public virtual DbSet<autos> autos { get; set; }
        public virtual DbSet<Clientes> clientes { get; set; }           
        public virtual DbSet<propietario> propietarios { get; set; }
        public virtual DbSet<ventas> ventas { get; set; }
        public virtual DbSet<Registros> registros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
