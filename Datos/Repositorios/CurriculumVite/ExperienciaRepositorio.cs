using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades.Modelos.CurriculumVite;
using Datos.IRepositorios.CurriculumVite;

namespace Datos.Repositorios.CurriculumVite
{
    public class ExperienciaRepositorio : IRepositorioExperiencia
    {
        private readonly ContextoBD _context;

        public ExperienciaRepositorio(ContextoBD context)
        {
            _context = context;
        }

        public async Task<IEnumerable<E_Experiencia>> GetAllAsync()
        {
            return await _context.Experiencias.ToListAsync();
        }

        public async Task<E_Experiencia> GetByIdAsync(int id)
        {
            return await _context.Experiencias.FindAsync(id);
        }

        public async Task AddAsync(E_Experiencia entity)
        {
            await _context.Experiencias.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(E_Experiencia entity)
        {
            _context.Experiencias.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Experiencias.FindAsync(id);
            if (entity != null)
            {
                _context.Experiencias.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
