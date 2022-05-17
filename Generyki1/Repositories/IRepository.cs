﻿namespace AplikacjaGIt2.Repositories;
    using AplikacjaGIt2.Entities;

public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
where T : class, IEntity
{
}
