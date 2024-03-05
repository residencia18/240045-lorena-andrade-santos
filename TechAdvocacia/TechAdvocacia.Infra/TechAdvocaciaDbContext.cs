using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechAdvocacia.Core.Entities;

namespace TechAdvocacia.Infra
{
    public class TechAdvocaciaDbContext : DbContext
    {
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Advogado> Advogados { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<CasoJuridico> CasoJuridicos { get; set; }

        public TechAdvocaciaDbContext(DbContextOptions<TechAdvocaciaDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TechAdvocaciaDbContext).Assembly);
        }
    }
}