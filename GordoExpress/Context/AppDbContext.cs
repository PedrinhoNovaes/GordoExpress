using GordoExpress.Models;
using Microsoft.EntityFrameworkCore;

namespace GordoExpress.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Bebida> Bebidas { get; set; }
    }
}
