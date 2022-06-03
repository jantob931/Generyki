namespace Generyki1.Data.Repositories;
using Generyki1.Data.Entities;
using Generyki1.Data.Repositories;

public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
where T : class, IEntity
{
}
