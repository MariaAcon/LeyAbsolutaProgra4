using LeyAbsolutaWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeyAbsolutaWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Expediente> Expedientes { get; set; }
        public DbSet<ExpedienteDetalle> ExpedienteDetalles { get; set; }
        public DbSet<ExpedienteImputado> ExpedienteImputados { get; set; }
        public DbSet<ExpedienteImputadoDetalle> ExpedienteImputadoDetalles { get; set; }
        public DbSet<Imputado> Imputados { get; set; }
        public DbSet<MaterialJudicial> MaterialJudiciales { get; set; }
        public DbSet<Resolucion> Resoluciones { get; set; }
    }
}


