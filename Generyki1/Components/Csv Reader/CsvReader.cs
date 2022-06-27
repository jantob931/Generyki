using Generyki1.Components.Csv_Reader.extensions;
using Generyki1.Components.Csv_Reader.Models;

namespace Generyki1.Components.Csv_Reader
{
    public class CsvReader : ICsvReader
    {
        public List<Car> ProcessCar(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<Car>();
            }
            var cars = File.ReadAllLines(filePath)
                .Skip(1)
                .Where(l => l.Length > 1)
                .ToCar();
                return cars.ToList();
        }

        public List<Manufacturer> ProcessManufacturer(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<Manufacturer> { };
            }
            var manufacturer =
                File.ReadAllLines(filePath)
                .Where(x => x.Length > 1)
                .Select(x =>
                {
                    var columns = x.Split(',');
                    return new Manufacturer()
                    {
                        Name = columns[0],
                        Country = columns[1],
                        Year = int.Parse(columns[2])
                    };
                });
            return manufacturer.ToList();
        }
    }
}
 