﻿using EL;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    public class BDMPOO : DbContext
    {
        public BDMPOO() : base(Conexion.ConexionString(false)) { }

        public virtual DbSet<Formularios>? Formularios { get; set; }
        public virtual DbSet<Permisos>? Permisos { get; set; }
        public virtual DbSet<Roles>? Roles { get; set; }
        public virtual DbSet<RolFormularios>? RolFormularios { get; set; }
        public virtual DbSet<RolPermisos>? RolPermisos { get; set; }
        public virtual DbSet<Usuarios>? Usuarios { get; set; }

    }
}