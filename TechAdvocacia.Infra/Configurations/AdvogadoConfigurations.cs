using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdvocacia.Core.Entities;

namespace TechAdvocacia.Infra.Configurations
{
    public class AdvogadoConfigurations : IEntityTypeConfiguration<Advogado>
    {
        public void Configure(EntityTypeBuilder<Advogado> builder)
        {
            builder
            .ToTable("Advogados")
            .HasKey(m => m.AdvogadoId);
        }
    }
}