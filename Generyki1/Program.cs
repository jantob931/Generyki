using AplikacjaGIt2.Entities;
using AplikacjaGIt2.Repositories;
using AplikacjaGIt2.Data;
using Generyki1.Repositories.Extensions;
var employeeRepository = new SqlRepository<Emplayee>(new AplikacjaDbContext(), EmplyeeAdded);
employeeRepository.ItemAdded += EmplyeeRepositoryOnItemAdded;

void EmplyeeRepositoryOnItemAdded(object? sender, Emplayee e)
{
    Console.WriteLine($"Employee added => {e.Name} from {sender?.GetType().Name}");
}

WriteAllToConsole(employeeRepository);
static void EmplyeeAdded(object item)
{
    var employee = (Emplayee)item;
    Console.WriteLine($"{employee.Name} ItemAdded");
}

static void AddEmployees(IRepository<BusinessPartner> businessPartnerRepository)
{
    var businessPartners = new[]
    {
        new BusinessPartner {},
        new BusinessPartner {},
        new BusinessPartner {},
        new BusinessPartner {}
    };
    businessPartnerRepository.AddBatch(businessPartners);
}
static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}
