namespace Entidades.DTO.CurriculumVite
{
    public class DistincionDTO
    {
        public int IdDistincion { get; set; }
        public int IdDocente { get; set; }
        public string? Nombre { get; set; }
        public string? Institucion { get; set; }
        public string? Descripcion { get; set; }
        public int Anio { get; set; }
    }
}
