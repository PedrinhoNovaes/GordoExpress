using GordoExpress.Context;
using GordoExpress.Models;
using GordoExpress.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GordoExpress.Repositories
{
    public class BebidaRepository : IBebidaRepository
    {
        private readonly AppDbContext _context;
        public BebidaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Bebida> Bebidas => _context.Bebidas.Include(c => c.Categoria);

        public IEnumerable<Bebida> BebidasPreferidas => _context.Bebidas.Where(l => l.IsBebidaPreferida).Include(c => c.Categoria);

        public Bebida GetBebidabyId(int bebidaId)
        {
            return _context.Bebidas.FirstOrDefault(l => l.BebidaId == bebidaId);
        }
    }
}
