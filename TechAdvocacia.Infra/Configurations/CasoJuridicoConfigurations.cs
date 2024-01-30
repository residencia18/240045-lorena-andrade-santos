using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdvocacia.Core.Entities;

namespace TechAdvocacia.Infra.Configurations
{
    public class CasoJuridicoConfigurations : IEntityTypeConfiguration<CasoJuridico>
    {
        public void Configure(EntityTypeBuilder<CasoJuridico> builder)
        {
            builder
            .ToTable("CasoJuridicos")
            .HasKey(m => m.CasoJuridicoId);
            
            builder
            .HasOne(c => c.Cliente)
            .WithOne(cj => cj.CasoJuridico)
            .HasForeignKey<CasoJuridico>(c=>c.ClienteId);

            builder
            .HasOne(m => m.Advogado)
            .WithOne(cj => cj.CasoJuridico)
            .HasForeignKey<CasoJuridico>(c=>c.AdvogadoId);

            builder
            .HasMany(m => m.Documentos)
            .WithOne(cj => cj.CasoJuridicos);
        }
    }
}