using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades.Modelos.CurriculumVite;
using Datos.IRepositorios.CurriculumVite;

namespace Datos.Repositorios.CurriculumVite
{
    public class DocumentoRepositorio : IRepositorioDocumento
    {
        private readonly CurriculumViteContext _context;

        public DocumentoRepositorio(CurriculumViteContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<E_Documento>> GetAllAsync()
        {
            return await _context.Documentos.ToListAsync();
        }

        public async Task<E_Documento> GetByIdAsync(int id)
        {
            return await _context.Documentos.FindAsync(id);
        }

        public async Task AddAsync(E_Documento entity)
        {
            await _context.Documentos.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(E_Documento entity)
        {
            _context.Documentos.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Documentos.FindAsync(id);
            if (entity != null)
            {
                _context.Documentos.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
