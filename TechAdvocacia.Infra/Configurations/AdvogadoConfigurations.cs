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

            // Configuração da relação 1:N entre Advogado e CasoJuridico
            builder
            .ToTable("Advogados")
            .HasKey(m => m.AdvogadoId);
        }
    }
}