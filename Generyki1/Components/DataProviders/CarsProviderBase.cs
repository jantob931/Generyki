using Generyki1.Components.DataProviders.Extensions;
using Generyki1.Components.DataProviders;
using Generyki1.Data.Entities;
using Generyki1.Data.Repositories;

namespace Generyki1.Components.DataProviders
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

        public Car FirstByColor(string color)
        {
            var cars = _carsRepository.GetAll();
            return cars.First(car => car.Color == color); 
        }
        public Car FirstOrDeafultByColor(string color)
        {
            var cars = _carsRepository.GetAll();
            return cars.FirstOrDefault(car => car.Color == color);
        }
        public Car FirstOrDeafultByColorWithFDeafult(string color)
        {
            var cars = _carsRepository.GetAll();
            return cars.FirstOrDefault(
                car => car.Color == color,
                new Car { Id=-1, Name="Not found"}
                );
        }

       
        public Car SingleById(int id)
        {
            var cars = _carsRepository.GetAll();
            return cars.Single(car => car.Id == id);
        }

        public Car? SingleOrDeafultById(int id)
        {
            var cars = _carsRepository.GetAll();
            return cars.SingleOrDefault(car => car.Id == id);
        }
        public Car LastByColor(string color)
        {
            var cars = _carsRepository.GetAll();
            return cars.Last(car => car.Color == color);
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
        public decimal GetMinimumPriceOfAllCars()
        {
            var cars = _carsRepository.GetAll();
            return cars.Select(x => x.ListPrice).Min();
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

        public List<Car> TakeCars(int howMany)
        {
            var cars = _carsRepository.GetAll();
            return cars
                .OrderBy(car => car.Name)
                .Take(howMany)
                .ToList();
        }

        public List<Car> TakeCars(Range range)
        {
            var cars = _carsRepository.GetAll();
            return cars
                .OrderBy(car => car.Name)
                .Take(range)
                .ToList();
        }

        public List<Car> TakeCarsWhileNameStartsWith(string prefix)
        {
            var cars = _carsRepository.GetAll();
            return cars
                .OrderBy(car => car.Name)
                .TakeWhile(Car=>Car.Name.StartsWith(prefix))
                .ToList();
        }

        public List<Car> SkipCars(int HowMany)
        {
            var cars = _carsRepository.GetAll();
            return cars
                .OrderBy(car => car.Name)
                .Skip(HowMany)
                .ToList();
        }

        public List<Car> SkipCarsWhileNameStartWith(string prefix)
        {
            var cars = _carsRepository.GetAll();
            return cars
                .OrderBy(car => car.Name)
                .SkipWhile(Car => Car.Name.StartsWith(prefix))
                .ToList();
        }

        public List<string> DistinctAllColors()
        {
            var cars = _carsRepository.GetAll();
            return cars
                .Select(car => car.Color)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
        }

        public List<Car> DistinctByColor()
        {
            var cars = _carsRepository.GetAll();
            return cars
                .DistinctBy(cars => cars.Color)
                .OrderBy(cars => cars.Color)
                .ToList();
        }

        public List<Car[]> ChunkCars(int size)
        {
            var cars = _carsRepository.GetAll();
            return cars.Chunk(size).ToList();
        }
    }
}
