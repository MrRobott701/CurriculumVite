namespace Entidades.DTO.CurriculumVite
{
    public class ContactoDocenteDTO
    {
        public int IdContacto { get; set; }
        public int IdDocente { get; set; }
        public int IdTipoContacto { get; set; }
        public string Url { get; set; } = null!;
    }
}
