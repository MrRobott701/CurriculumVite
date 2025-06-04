using System.Collections.Generic;
using System.Threading.Tasks;
using Entidades.Modelos.CurriculumVite;

namespace Servicios.IRepositorios.CurriculumVite
{
    public interface ISRepositorioContactoDocente
    {
        Task<IEnumerable<E_ContactoDocente>> GetAllAsync();
        Task<E_ContactoDocente> GetByIdAsync(int id);
        Task AddAsync(E_ContactoDocente entity);
        Task UpdateAsync(E_ContactoDocente entity);
        Task DeleteAsync(int id);
    }
}
