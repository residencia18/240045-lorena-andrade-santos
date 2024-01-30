using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechAdvocacia.Core.Entities;

namespace TechAdvocacia.Infra.Configurations
{
    public class DocumentoConfigurations : IEntityTypeConfiguration<Documento>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Documento> builder)
        {
            builder
            .ToTable("Documentos")
            .HasKey(m => m.DocumentoId);
        }
    }
}