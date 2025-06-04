namespace Entidades.DTO.CurriculumVite
{
    public class PublicacionDTO
    {
        public int IdPublicacion { get; set; }
        public int IdDocente { get; set; }
        public string? Titulo { get; set; }
        public string? TipoPublicacion { get; set; }
        public string? Autores { get; set; }
        public string? Fuente { get; set; }
        public int? Anio { get; set; }
        public string Enlace { get; set; } = null!;
    }
}
