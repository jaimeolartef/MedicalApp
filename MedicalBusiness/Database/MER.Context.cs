﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalBusiness.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MedicalAppEntitiesDev : DbContext
    {
        public MedicalAppEntitiesDev()
            : base("name=MedicalAppEntitiesDev")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CitasMedicas> CitasMedicas { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<ProfesionalSalud> ProfesionalSalud { get; set; }
        public virtual DbSet<Sedes> Sedes { get; set; }
    }
}