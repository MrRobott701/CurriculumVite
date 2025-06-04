using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades.Modelos.CurriculumVite;
using Datos.IRepositorios.CurriculumVite;

namespace Datos.Repositorios.CurriculumVite
{
    public class EducacionRepositorio : IRepositorioEducacion
    {
        private readonly ContextoBD _context;

        public EducacionRepositorio(ContextoBD context)
        {
            _context = context;
        }

        public async Task<IEnumerable<E_Educacion>> GetAllAsync()
        {
            return await _context.Educaciones.ToListAsync();
        }

        public async Task<E_Educacion> GetByIdAsync(int id)
        {
            return await _context.Educaciones.FindAsync(id);
        }

        public async Task AddAsync(E_Educacion entity)
        {
            await _context.Educaciones.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(E_Educacion entity)
        {
            _context.Educaciones.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Educaciones.FindAsync(id);
            if (entity != null)
            {
                _context.Educaciones.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
