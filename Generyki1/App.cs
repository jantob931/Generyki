using AplikacjaGIt2.Entities;
using AplikacjaGIt2.Repositories;

namespace Generyki1
{
    public class AppBase : IApp
    {
        private readonly IRepository<Emplayee> _employeesrepository;
        public AppBase(IRepository<Emplayee> EmployeeRepository)
        {
            _employeesrepository = EmployeeRepository;
        }
        public void Run()
        {
            Console.WriteLine("I am Here in Run() method");

            var employees = new[]
            {
                new Emplayee {Name = "Adam"},
                new Emplayee {Name ="Jan"}
            };
            foreach (var employee in employees)
            {
                _employeesrepository.Add(employee);
            }
            _employeesrepository.Save();

            var items = _employeesrepository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}