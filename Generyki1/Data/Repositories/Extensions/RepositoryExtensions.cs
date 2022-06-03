using Generyki1.Data.Entities;
using Generyki1.Data.Repositories;

namespace Generyki1.Data.Repositories.Extensions
{
    public static class RepositoryExtensions
    {
        public static void AddBatch<T>(this IRepository<T> repository, T[] items)
         where T : class, IEntity
        {
            foreach (var item in items)
            {
                repository.Add(item);
            }
            repository.Save();
        }
    }
}
