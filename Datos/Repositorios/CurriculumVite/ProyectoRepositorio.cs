using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades.Modelos.CurriculumVite;
using Datos.IRepositorios.CurriculumVite;

namespace Datos.Repositorios.CurriculumVite
{
    public class ProyectoRepositorio : IRepositorioProyecto
    {
        private readonly ContextoBD _context;

        public ProyectoRepositorio(ContextoBD context)
        {
            _context = context;
        }

        public async Task<IEnumerable<E_Proyecto>> GetAllAsync()
        {
            return await _context.Proyectos.ToListAsync();
        }

        public async Task<E_Proyecto> GetByIdAsync(int id)
        {
            return await _context.Proyectos.FindAsync(id);
        }

        public async Task AddAsync(E_Proyecto entity)
        {
            await _context.Proyectos.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(E_Proyecto entity)
        {
            _context.Proyectos.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Proyectos.FindAsync(id);
            if (entity != null)
            {
                _context.Proyectos.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
