using AplikacjaGIt2.Entities;
using AplikacjaGIt2.Repositories;
using AplikacjaGIt2.Data;

var employeeRepository = new SqlRepository<Emplayee>(new AplikacjaDbContext());
AddEmployees(employeeRepository);
AddManager(employeeRepository);
    


static void AddEmployees(IRepository<Emplayee> employeeRepository)
{
    employeeRepository.Add(new Emplayee { Name = "Jan" });
    employeeRepository.Save();
    
}
static void AddManager(IRepository<Emplayee> employeeRepository)
{
    employeeRepository.Add(new Manager { Name = "Adam" });
    employeeRepository.Save();
}