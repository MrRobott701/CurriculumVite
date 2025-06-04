using AutoMapper;
using Entidades.DTO.CurriculumVite;
using Entidades.Modelos.CurriculumVite;

namespace Entidades.PerfilesDTO.CurriculumVite
{
    public class ContactoDocenteProfile : Profile
    {
        public ContactoDocenteProfile()
        {
            CreateMap<ContactoDocenteDTO, E_ContactoDocente>().ReverseMap();
        }
    }
}
