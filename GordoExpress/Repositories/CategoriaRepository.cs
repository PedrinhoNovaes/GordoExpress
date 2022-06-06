using GordoExpress.Context;
using GordoExpress.Models;
using GordoExpress.Repositories.Interfaces;

namespace GordoExpress.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
