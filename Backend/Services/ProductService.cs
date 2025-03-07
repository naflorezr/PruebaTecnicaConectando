using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.DbConnection;
using PruebaTecnica.Models;

namespace PruebaTecnica.Services
{
    public class ProductService
    {
        private readonly DbConnectionContext _dbContext;

        public ProductService(DbConnectionContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Producto>> GetProductosAsync()
        {
            return await _dbContext.Producto.ToListAsync();
        }
        public async Task AddProductAsync(Producto product)
        {
            await _dbContext.Producto.AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Producto product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _dbContext.Producto.FindAsync(id);
            _dbContext.Producto.Remove(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}
