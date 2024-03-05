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
            .HasOne(cj => cj.Advogado)
            .WithMany(a => a.CasosJuridicos)
            .HasForeignKey(cj => cj.AdvogadoId);


            builder
            .HasOne(cj => cj.Cliente)
            .WithMany(c => c.CasosJuridicos)
            .HasForeignKey(cj => cj.ClienteId);

        }
    }
}