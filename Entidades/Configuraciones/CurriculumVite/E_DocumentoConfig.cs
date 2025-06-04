using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Entidades.Modelos.CurriculumVite;

namespace Entidades.Configuraciones.CurriculumVite
{
    public class E_DocumentoConfig : IEntityTypeConfiguration<E_Documento>
    {
        public void Configure(EntityTypeBuilder<E_Documento> builder)
        {
            builder.ToTable("Documento");
            builder.HasKey(e => e.IdDocumento);
            builder.Property(e => e.IdDocente).IsRequired();
            builder.Property(e => e.IdPublicacion);
            builder.Property(e => e.IdDistincion);
            builder.Property(e => e.IdProyecto);
            builder.Property(e => e.IdTesis);
            builder.Property(e => e.IdEducacion);
            builder.Property(e => e.Titulo).HasMaxLength(255).IsRequired();
            builder.Property(e => e.Url).IsRequired();
            builder.Property(e => e.Descripcion);
            builder.Property(e => e.FechaSubida).IsRequired();
        }
    }
}
