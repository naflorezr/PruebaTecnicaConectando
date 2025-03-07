using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;

namespace PruebaTecnica.DbConnection
{
    public class DbConnectionContext: DbContext
    {
        public DbConnectionContext(DbContextOptions<DbConnectionContext> options) : base(options)
        {}
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
    }
}
