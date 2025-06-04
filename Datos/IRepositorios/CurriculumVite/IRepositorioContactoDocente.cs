using System.Collections.Generic;
using System.Threading.Tasks;
using Entidades.Modelos.CurriculumVite;

namespace Datos.IRepositorios.CurriculumVite
{
    public interface IRepositorioContactoDocente
    {
        Task<IEnumerable<E_ContactoDocente>> GetAllAsync();
        Task<E_ContactoDocente> GetByIdAsync(int id);
        Task AddAsync(E_ContactoDocente entity);
        Task UpdateAsync(E_ContactoDocente entity);
        Task DeleteAsync(int id);
    }
}
