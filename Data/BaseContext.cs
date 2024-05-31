using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Models;

namespace Prueba.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        //modelos
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Tratamiento> Tratamientos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cita>().Property(c => c.Estado).HasConversion<string>();
            modelBuilder.Entity<Medico>().Property(c => c.Estado).HasConversion<string>();
            modelBuilder.Entity<Especialidad>().Property(c => c.Estado).HasConversion<string>();
            modelBuilder.Entity<Paciente>().Property(c => c.Estado).HasConversion<string>();
            modelBuilder.Entity<Tratamiento>().Property(c => c.Estado).HasConversion<string>();
        }
    }
}