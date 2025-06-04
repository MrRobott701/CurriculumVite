using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades.Modelos.CurriculumVite;

namespace Entidades.Configuraciones.CurriculumVite
{
    public class E_ExperienciaConfig : IEntityTypeConfiguration<E_Experiencia>
    {
        public void Configure(EntityTypeBuilder<E_Experiencia> builder)
        {
            builder.ToTable("Experiencia");
            builder.HasKey(e => e.IdExperiencia);
            builder.Property(e => e.IdDocente).IsRequired();
            builder.Property(e => e.Puesto).HasMaxLength(200);
            builder.Property(e => e.Institucion).HasMaxLength(200);
            builder.Property(e => e.Descripcion);
            builder.Property(e => e.FechaInicio);
            builder.Property(e => e.FechaFin).IsRequired();
        }
    }
}
