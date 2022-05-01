namespace AplikacjaGIt2.Entities
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
