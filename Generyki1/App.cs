using Generyki1.Components.Csv_Reader;
using Generyki1.Data.Entities;
using Generyki1.Data.Repositories;
using Generyki1.Components.Csv_Reader.Models;
namespace Generyki1
{
    public class AppBase : IApp
    {
        private readonly ICsvReader _csvReader;
        public AppBase(ICsvReader csvReader)
        {
            _csvReader = csvReader;
        }
        public void Run()
        {
            var cars = _csvReader.ProcessCar("C:\\Users\\Jan Tobiczyk\\source\\repos\\Generyki\\Generyki1\\resources\\Files\\fuel.csv");
            var manufacturers = _csvReader.ProcessManufacturer("resources\\Files\\manufacturers.csv");
           
        }

    }
}