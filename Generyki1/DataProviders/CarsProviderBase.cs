using AplikacjaGIt2.Repositories;
using Generyki1.Entities;

namespace Generyki1.DataProviders
{
    public class CarsProviderBase : ICarsProvider
    {
        private readonly IRepository<Car> _carsRepository;
        public CarsProviderBase(IRepository<Car> _carsRepository)
        {
            _carsRepository = _carsRepository;
        }
        public string AnonymusClass()
        {
            var cars = _carsRepository.GetAll();
            var list = cars.Select(car => new 
            {
                Id = car.Id,
                Name = car.Name,
                Type = car.Type,
            }).ToList();
            return string.Join("U+002CU+0020", list);
            
        }

        public decimal GetMinimumPriceOfAllCars()
        {
            var cars = _carsRepository.GetAll();
            return cars.Select(x=>x.ListPrice).Min();
        }

        public List<Car> GetSpecificColumns()
        {
            var cars = _carsRepository.GetAll();
            var list = cars.Select(car => new Car
            {
                Id = car.Id,
                Name = car.Name,
                Type = car.Type,
            }).ToList();
            return list;
        }

        public List<string> GetUniqueCarColor()
        {
            var cars = _carsRepository.GetAll();
            var colors = cars.Select(c => c.Color).Distinct().ToList();
            return colors;
        }
    }
}