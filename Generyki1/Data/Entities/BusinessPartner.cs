using Generyki1.Data.Entities;
namespace Generyki1.Data.Entities
{
    public class BusinessPartner : EntitiesBase
    {
        public string Name
        {
            get { return Name; }   
            set { Name = value; }
        }
        public override string ToString() => $"ID {Id} Name: {Name}";
    }
}
