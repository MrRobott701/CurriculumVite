using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades.Modelos.CurriculumVite;
using Datos.IRepositorios.CurriculumVite;

namespace Datos.Repositorios.CurriculumVite
{
    public class PublicacionRepositorio : IRepositorioPublicacion
    {
        private readonly CurriculumViteContext _context;

        public PublicacionRepositorio(CurriculumViteContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<E_Publicacion>> GetAllAsync()
        {
            return await _context.Publicaciones.ToListAsync();
        }

        public async Task<E_Publicacion> GetByIdAsync(int id)
        {
            return await _context.Publicaciones.FindAsync(id);
        }

        public async Task AddAsync(E_Publicacion entity)
        {
            await _context.Publicaciones.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(E_Publicacion entity)
        {
            _context.Publicaciones.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Publicaciones.FindAsync(id);
            if (entity != null)
            {
                _context.Publicaciones.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
