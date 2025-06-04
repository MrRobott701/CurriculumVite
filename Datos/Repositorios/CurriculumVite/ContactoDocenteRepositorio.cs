using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades.Modelos.CurriculumVite;
using Datos.IRepositorios.CurriculumVite;

namespace Datos.Repositorios.CurriculumVite
{
    public class ContactoDocenteRepositorio : IRepositorioContactoDocente
    {
        private readonly CurriculumViteContext _context;

        public ContactoDocenteRepositorio(CurriculumViteContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<E_ContactoDocente>> GetAllAsync()
        {
            return await _context.ContactoDocentes.ToListAsync();
        }

        public async Task<E_ContactoDocente> GetByIdAsync(int id)
        {
            return await _context.ContactoDocentes.FindAsync(id);
        }

        public async Task AddAsync(E_ContactoDocente entity)
        {
            await _context.ContactoDocentes.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(E_ContactoDocente entity)
        {
            _context.ContactoDocentes.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.ContactoDocentes.FindAsync(id);
            if (entity != null)
            {
                _context.ContactoDocentes.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
