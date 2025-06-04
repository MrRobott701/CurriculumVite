using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades.Modelos.CurriculumVite;

namespace Entidades.Configuraciones.CurriculumVite
{
    public class E_DistincionConfig : IEntityTypeConfiguration<E_Distincion>
    {
        public void Configure(EntityTypeBuilder<E_Distincion> builder)
        {
            builder.ToTable("Distincion");
            builder.HasKey(e => e.IdDistincion);
            builder.Property(e => e.IdDocente).IsRequired();
            builder.Property(e => e.Nombre).HasMaxLength(200);
            builder.Property(e => e.Institucion).HasMaxLength(200);
            builder.Property(e => e.Descripcion);
            builder.Property(e => e.Anio).IsRequired();
        }
    }
}
