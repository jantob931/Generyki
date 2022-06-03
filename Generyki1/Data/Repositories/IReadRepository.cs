using Generyki1.Data.Entities;

namespace Generyki1.Data.Repositories
{
    public interface IReadRepository<out T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
