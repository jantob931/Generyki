namespace AplikacjaGIt2.Repositories
{
    using AplikacjaGIt2.Entities;
    using AplikacjaGIt2.Repositories;
    using System.Collections.Generic;

    public class ListRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private readonly List<T> _Items = new();

        public void Add(T item)
        {
            item.Id = _Items.Count + 1;
            _Items.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _Items.ToList();
        }
      
        public T GetById(int id)
        {
            return _Items.Single(item => item.Id == id);
        }

        public void Remove(T item)
        {
            _Items.Remove(item);
        }

        public void Save()
        {
           
        }
    }
}

 

