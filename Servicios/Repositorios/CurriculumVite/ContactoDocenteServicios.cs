using System.Collections.Generic;
using System.Threading.Tasks;
using Entidades.Modelos.CurriculumVite;
using Servicios.IRepositorios.CurriculumVite;
using Datos.IRepositorios.CurriculumVite;

namespace Servicios.Repositorios.CurriculumVite
{
    public class ContactoDocenteServicios : IRepositorios.CurriculumVite.ISRepositorioContactoDocente
    {
        private readonly IRepositorios.CurriculumVite.ISRepositorioContactoDocente _repo;

        public ContactoDocenteServicios(IRepositorios.CurriculumVite.ISRepositorioContactoDocente repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<E_ContactoDocente>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<E_ContactoDocente> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task AddAsync(E_ContactoDocente entity)
        {
            await _repo.AddAsync(entity);
        }

        public async Task UpdateAsync(E_ContactoDocente entity)
        {
            await _repo.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }
    }
}
