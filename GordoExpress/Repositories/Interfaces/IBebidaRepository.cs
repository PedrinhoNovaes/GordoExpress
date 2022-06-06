using GordoExpress.Models;

namespace GordoExpress.Repositories.Interfaces
{
    public interface IBebidaRepository
    {
        IEnumerable<Bebida> Bebidas { get; }
        IEnumerable<Bebida> BebidasPreferidas { get; }
        Bebida GetBebidabyId(int bebidaId);
    }
}
