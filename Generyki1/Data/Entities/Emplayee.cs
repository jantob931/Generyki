using Generyki1.Data.Entities;
namespace Generyki1.Data.Entities
{
    public class Emplayee : EntitiesBase
    {
        public string Name { get; set; }
        public override string ToString() => $"ID {Id} Name: {Name}";
    }
}
