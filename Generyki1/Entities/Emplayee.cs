namespace AplikacjaGIt2.Entities
{
    public class Emplayee : EntitiesBase
    {
        public string Name { get; set; }
        public override string ToString() => $"ID {Id} Name: {Name}";
    }
}
