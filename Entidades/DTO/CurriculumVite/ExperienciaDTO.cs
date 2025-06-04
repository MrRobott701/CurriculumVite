using System;

namespace Entidades.DTO.CurriculumVite
{
    public class ExperienciaDTO
    {
        public int IdExperiencia { get; set; }
        public int IdDocente { get; set; }
        public string? Puesto { get; set; }
        public string? Institucion { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
