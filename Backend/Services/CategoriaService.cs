using Microsoft.EntityFrameworkCore;
using PruebaTecnica.DbConnection;
using PruebaTecnica.Models;

namespace PruebaTecnica.Services
{
    public class CategoriaService
    {
        private readonly DbConnectionContext _dbContext;

        public CategoriaService(DbConnectionContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Categoria>> GetProductosAsync()
        {
            return await _dbContext.Categoria.ToListAsync();
        }
        public async Task AddProductAsync(Categoria category)
        {
            await _dbContext.Categoria.AddAsync(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Categoria category)
        {
            _dbContext.Entry(category).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var category = await _dbContext.Categoria.FindAsync(id);
            _dbContext.Categoria.Remove(category);
            await _dbContext.SaveChangesAsync();
        }
    }
}
