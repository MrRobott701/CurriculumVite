using System.Collections.Generic;
using System.Threading.Tasks;
using Entidades.Modelos.CurriculumVite;
using Servicios.IRepositorios.CurriculumVite;
using Datos.IRepositorios.CurriculumVite;

namespace Servicios.Repositorios.CurriculumVite
{
    public class DocumentoServicios : ISRepositorioDocumento
    {
        private readonly IRepositorioDocumento _repo;

        public DocumentoServicios(IRepositorioDocumento repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<E_Documento>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<E_Documento> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task AddAsync(E_Documento entity)
        {
            await _repo.AddAsync(entity);
        }

        public async Task UpdateAsync(E_Documento entity)
        {
            await _repo.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }
    }
}
