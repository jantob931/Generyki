using AplikacjaGIt2.Repositories;
using Generyki1.DataProviders.Extensions;
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

        public List<Car> OrderByColorAndName()
        {
            var cars = _carsRepository.GetAll();
            var colors = cars
                .OrderBy(c => c.Color)
                .ThenBy(c => c.Name)
                .ToList();
            return colors;

        }

        public List<Car> OrderByColorAndNameDesc()
        {
            var cars = _carsRepository.GetAll();
            var colors = cars
                .OrderByDescending(c => c.Color)
                .ThenByDescending(c => c.Name)
                .ToList();
            return colors;
        }

        public List<Car> OrderByName()
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderBy(x => x.Name).ToList();
        }

        public List<Car> OrderByNameDescending()
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderByDescending(x => x.Name).ToList();
        }

        public List<Car> WhereColorIs(string color)
        {
            var cars = _carsRepository.GetAll();
            return cars.ByColor("Blue").ToList();
        }

        public List<Car> WhereStartsWith(string prefix)
        {
            var cars = _carsRepository.GetAll();
            return cars.Where(x=>x.Name.StartsWith(prefix)).ToList();
        }

        public List<Car> WhereStartsWithAndCostIsGreaterThan(string prefix, decimal cost)
        {
            var cars = _carsRepository.GetAll();
            return cars.Where(x => x.Name.StartsWith(prefix) && x.StandardCosr > cost).ToList();
        }
    }
}