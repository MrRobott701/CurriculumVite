using System.Collections.Generic;
using System.Threading.Tasks;
using Entidades.Modelos.CurriculumVite;
using Servicios.IRepositorios.CurriculumVite;
using Datos.IRepositorios.CurriculumVite;

namespace Servicios.Repositorios.CurriculumVite
{
    public class ProyectoServicios : IRepositorios.CurriculumVite.ISRepositorioProyecto
    {
        private readonly IRepositorios.CurriculumVite.ISRepositorioProyecto _repo;

        public ProyectoServicios(IRepositorios.CurriculumVite.ISRepositorioProyecto repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<E_Proyecto>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<E_Proyecto> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task AddAsync(E_Proyecto entity)
        {
            await _repo.AddAsync(entity);
        }

        public async Task UpdateAsync(E_Proyecto entity)
        {
            await _repo.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }
    }
}
