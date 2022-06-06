using GordoExpress.Models;

namespace GordoExpress.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get;  }

    }
}
