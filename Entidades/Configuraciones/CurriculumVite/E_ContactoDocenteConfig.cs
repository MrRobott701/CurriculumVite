using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entidades.Modelos.CurriculumVite;

namespace Entidades.Configuraciones.CurriculumVite
{
    public class E_ContactoDocenteConfig : IEntityTypeConfiguration<E_ContactoDocente>
    {
        public void Configure(EntityTypeBuilder<E_ContactoDocente> builder)
        {
            builder.ToTable("ContactoDocente");
            builder.HasKey(e => e.IdContacto);
            builder.Property(e => e.IdDocente).IsRequired();
            builder.Property(e => e.IdTipoContacto).IsRequired();
            builder.Property(e => e.Url).IsRequired();
        }
    }
}
